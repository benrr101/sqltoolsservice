﻿//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using System;
using System.Threading.Tasks;
using Microsoft.SqlTools.ServiceLayer.Connection;
using Microsoft.SqlTools.ServiceLayer.Connection.Contracts;
using Microsoft.SqlTools.ServiceLayer.Hosting.Protocol;
using Microsoft.SqlTools.ServiceLayer.ObjectExplorer;
using Microsoft.SqlTools.ServiceLayer.ObjectExplorer.Contracts;
using Microsoft.SqlTools.ServiceLayer.ObjectExplorer.Nodes;
using Microsoft.SqlTools.ServiceLayer.Test.Utility;
using Microsoft.SqlTools.Test.Utility;
using Moq;
using Xunit;

namespace Microsoft.SqlTools.ServiceLayer.Test.ObjectExplorer
{

    public class ObjectExplorerServiceTests
    {
        private ObjectExplorerService service;
        private Mock<ConnectionService> connectionServiceMock;
        private Mock<IProtocolEndpoint> serviceHostMock;
        public ObjectExplorerServiceTests()
        {
            connectionServiceMock = new Mock<ConnectionService>();
            serviceHostMock = new Mock<IProtocolEndpoint>();
            service = new ObjectExplorerService(connectionServiceMock.Object);
            service.InitializeService(serviceHostMock.Object);
        }

        [Fact]
        public async Task CreateSessionRequestErrorsIfConnectionDetailsIsNull()
        {
            object errorResponse = null;
            var contextMock = RequestContextMocks.Create<CreateSessionResponse>(null)
                                                 .AddErrorHandling(obj => errorResponse = obj);

            await service.HandleCreateSessionRequest(null, contextMock.Object);
            VerifyErrorSent(contextMock);
            Assert.True(((string)errorResponse).Contains("ArgumentNullException"));
        }
        
        [Fact]
        public async Task CreateSessionRequestReturnsFalseOnConnectionFailure()
        {
            // Given the connection service fails to connect
            ConnectionDetails details = TestObjects.GetTestConnectionDetails();
            ConnectionCompleteParams completeParams = null;
            serviceHostMock.AddEventHandling(ConnectionCompleteNotification.Type, (et, p) => completeParams = p);

            string expectedExceptionText = "Error!!!";
            connectionServiceMock.Setup(c => c.Connect(It.IsAny<ConnectParams>()))
                .Throws(new Exception(expectedExceptionText));

            // when creating a new session
            // then expect the create session request to return false
            await RunAndVerify<CreateSessionResponse>(
                test: (requestContext) => service.HandleCreateSessionRequest(details, requestContext),
                verify: (actual =>
                {
                    Assert.False(actual.Success);
                    Assert.Null(actual.SessionId);
                    Assert.Null(actual.RootNode);
                }));

            // And expect error notification to be sent
            serviceHostMock.Verify(x => x.SendEvent(ConnectionCompleteNotification.Type, It.IsAny<ConnectionCompleteParams>()), Times.Once());
            Assert.NotNull(completeParams);
            Assert.True(completeParams.Messages.Contains(expectedExceptionText));
        }


        [Fact]
        public async Task CreateSessionRequestReturnsSuccessAndNodeInfo()
        {
            // Given the connection service fails to connect
            ConnectionDetails details = TestObjects.GetTestConnectionDetails();
            serviceHostMock.AddEventHandling(ConnectionCompleteNotification.Type, null);
            
            connectionServiceMock.Setup(c => c.Connect(It.IsAny<ConnectParams>()))
                .Returns((ConnectParams connectParams) => Task.FromResult(GetCompleteParamsForConnection(connectParams.OwnerUri, details)));
            
            // when creating a new session
            // then expect the create session request to return false
            await RunAndVerify<CreateSessionResponse>(
                test: (requestContext) => service.HandleCreateSessionRequest(details, requestContext),
                verify: (actual =>
                {
                    Assert.True(actual.Success);
                    Assert.NotNull(actual.SessionId);
                    VerifyServerNode(actual.RootNode, details);
                }));

            // And expect no error notification to be sent
            serviceHostMock.Verify(x => x.SendEvent(ConnectionCompleteNotification.Type, 
                It.IsAny<ConnectionCompleteParams>()), Times.Never());
        }

        private void VerifyServerNode(NodeInfo serverNode, ConnectionDetails details)
        {
            Assert.NotNull(serverNode);
            Assert.Equal(NodeTypes.ServerInstance.ToString(), serverNode.NodeType);
            Assert.Equal(1, serverNode.NodePath.Length);
            Assert.Equal(details.ServerName, serverNode.NodePath[0]);
            Assert.True(serverNode.Label.Contains(details.ServerName));
            Assert.False(serverNode.IsLeaf);
        }

        private static ConnectionCompleteParams GetCompleteParamsForConnection(string uri, ConnectionDetails details)
        {
            return new ConnectionCompleteParams()
            {
                OwnerUri = uri,
                ConnectionSummary = new ConnectionSummary()
                {
                    ServerName = details.ServerName,
                    DatabaseName = details.DatabaseName,
                    UserName = details.UserName
                },
                ServerInfo = TestObjects.GetTestServerInfo()
            };
        }

        private async Task RunAndVerify<T>(Func<RequestContext<T>, Task> test, Action<T> verify)
        {
            T result = default(T);
            var contextMock = RequestContextMocks.Create<T>(r => result = r).AddErrorHandling(null);
            await test(contextMock.Object);
            VerifyResult(contextMock, verify, result);
        }
        
        private void VerifyResult<T>(Mock<RequestContext<T>> contextMock, Action<T> verify, T actual)
        {
            contextMock.Verify(c => c.SendResult(It.IsAny<T>()), Times.Once);
            contextMock.Verify(c => c.SendError(It.IsAny<string>()), Times.Never);
            verify(actual);
        }

        private void VerifyErrorSent<T>(Mock<RequestContext<T>> contextMock)
        {
            contextMock.Verify(c => c.SendResult(It.IsAny<T>()), Times.Never);
            contextMock.Verify(c => c.SendError(It.IsAny<string>()), Times.Once);
        }

    }
}