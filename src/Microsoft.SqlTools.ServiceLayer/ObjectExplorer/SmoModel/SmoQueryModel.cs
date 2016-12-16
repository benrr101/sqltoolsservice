﻿
// This file was generated by a T4 Template. Do not modify directly, instead update the SmoQueryModelDefinition.xml file
// and re-run the T4 template. This can be done in Visual Studio by right-click in and choosing "Run Custom Tool",
// or from the command-line on any platform by running "build.cmd -Target=CodeGen" or "build.sh -Target=CodeGen".

using System.Collections.Generic;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Smo.Broker;

namespace Microsoft.SqlTools.ServiceLayer.ObjectExplorer.SmoModel
{
	
    internal partial class SqlDatabaseQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Server parentServer = context.Parent as Server;
            if (parentServer != null)
            {
                var retValue = parentServer.Databases;
                return new SmoCollectionWrapper<Database>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlLinkedServerLoginQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Server parentServer = context.Parent as Server;
            if (parentServer != null)
            {
                var retValue = parentServer.LinkedServers;
                return new SmoCollectionWrapper<LinkedServer>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlLoginQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Server parentServer = context.Parent as Server;
            if (parentServer != null)
            {
                var retValue = parentServer.Logins;
                return new SmoCollectionWrapper<Login>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlServerRoleQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Server parentServer = context.Parent as Server;
            if (parentServer != null)
            {
                var retValue = parentServer.Roles;
                return new SmoCollectionWrapper<ServerRole>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlCredentialQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Server parentServer = context.Parent as Server;
            if (parentServer != null)
            {
                var retValue = parentServer.Credentials;
                return new SmoCollectionWrapper<Credential>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlCryptographicProviderQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Server parentServer = context.Parent as Server;
            if (parentServer != null)
            {
                var retValue = parentServer.CryptographicProviders;
                return new SmoCollectionWrapper<CryptographicProvider>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlServerAuditQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Server parentServer = context.Parent as Server;
            if (parentServer != null)
            {
                var retValue = parentServer.Audits;
                return new SmoCollectionWrapper<Audit>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlServerAuditSpecificationQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Server parentServer = context.Parent as Server;
            if (parentServer != null)
            {
                var retValue = parentServer.ServerAuditSpecifications;
                return new SmoCollectionWrapper<ServerAuditSpecification>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlEndpointQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Server parentServer = context.Parent as Server;
            if (parentServer != null)
            {
                var retValue = parentServer.Endpoints;
                return new SmoCollectionWrapper<Endpoint>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlLinkedServerQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Server parentServer = context.Parent as Server;
            if (parentServer != null)
            {
                var retValue = parentServer.LinkedServers;
                return new SmoCollectionWrapper<LinkedServer>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlServerDdlTriggerQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Server parentServer = context.Parent as Server;
            if (parentServer != null)
            {
                var retValue = parentServer.Triggers;
                return new SmoCollectionWrapper<ServerDdlTrigger>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlErrorMessageQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Server parentServer = context.Parent as Server;
            if (parentServer != null)
            {
                var retValue = parentServer.UserDefinedMessages;
                return new SmoCollectionWrapper<UserDefinedMessage>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlTableQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.Tables;
                return new SmoCollectionWrapper<Table>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlViewQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.Views;
                return new SmoCollectionWrapper<View>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlSynonymQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.Synonyms;
                return new SmoCollectionWrapper<Synonym>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlColumnQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            TableViewTableTypeBase parentTableViewTableTypeBase = context.Parent as TableViewTableTypeBase;
            if (parentTableViewTableTypeBase != null)
            {
                var retValue = parentTableViewTableTypeBase.Columns;
                return new SmoCollectionWrapper<Column>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlIndexQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            TableViewTableTypeBase parentTableViewTableTypeBase = context.Parent as TableViewTableTypeBase;
            if (parentTableViewTableTypeBase != null)
            {
                var retValue = parentTableViewTableTypeBase.Indexes;
                return new SmoCollectionWrapper<Index>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlCheckQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Table parentTable = context.Parent as Table;
            if (parentTable != null)
            {
                var retValue = parentTable.Checks;
                return new SmoCollectionWrapper<Check>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlForeignKeyConstraintQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Table parentTable = context.Parent as Table;
            if (parentTable != null)
            {
                var retValue = parentTable.ForeignKeys;
                return new SmoCollectionWrapper<ForeignKey>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlDefaultConstraintQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Column parentColumn = context.Parent as Column;
            if (parentColumn != null)
            {
                var retValue = parentColumn.DefaultConstraint;
                return new SqlSmoObject[] { retValue };
            }
            return null;
        }
    }

    internal partial class SqlDmlTriggerQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Table parentTable = context.Parent as Table;
            if (parentTable != null)
            {
                var retValue = parentTable.Triggers;
                return new SmoCollectionWrapper<Trigger>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlFullTextIndexQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Table parentTable = context.Parent as Table;
            if (parentTable != null)
            {
                var retValue = parentTable.FullTextIndex;
                return new SqlSmoObject[] { retValue };
            }
            return null;
        }
    }

    internal partial class SqlStatisticQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            TableViewBase parentTableViewBase = context.Parent as TableViewBase;
            if (parentTableViewBase != null)
            {
                var retValue = parentTableViewBase.Statistics;
                return new SmoCollectionWrapper<Statistic>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlDatabaseDdlTriggerQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.Triggers;
                return new SmoCollectionWrapper<Trigger>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlAssemblyQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.Assemblies;
                return new SmoCollectionWrapper<SqlAssembly>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlRuleQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.Rules;
                return new SmoCollectionWrapper<Rule>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlDefaultQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.Defaults;
                return new SmoCollectionWrapper<Default>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlSequenceQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.Sequences;
                return new SmoCollectionWrapper<Sequence>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlSystemDataTypeQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Server parentServer = context.Parent as Server;
            if (parentServer != null)
            {
                var retValue = parentServer.SystemDataTypes;
                return new SmoCollectionWrapper<SystemDataType>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlUserDefinedDataTypeQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.UserDefinedDataTypes;
                return new SmoCollectionWrapper<UserDefinedDataType>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlUserDefinedTableTypeQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.UserDefinedTableTypes;
                return new SmoCollectionWrapper<UserDefinedTableType>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlXmlSchemaCollectionQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.XmlSchemaCollections;
                return new SmoCollectionWrapper<XmlSchemaCollection>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlUserDefinedTypeQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.UserDefinedTypes;
                return new SmoCollectionWrapper<UserDefinedType>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlUserDefinedFunctionQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.UserDefinedFunctions;
                return new SmoCollectionWrapper<UserDefinedFunction>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlUserDefinedAggregateQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.UserDefinedAggregates;
                return new SmoCollectionWrapper<UserDefinedAggregate>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlFileGroupQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.FileGroups;
                return new SmoCollectionWrapper<FileGroup>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlFileQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            FileGroup parentFileGroup = context.Parent as FileGroup;
            if (parentFileGroup != null)
            {
                var retValue = parentFileGroup.Files;
                return new SmoCollectionWrapper<DataFile>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlFullTextCatalogQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.FullTextCatalogs;
                return new SmoCollectionWrapper<FullTextCatalog>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlFullTextStopListQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.FullTextStopLists;
                return new SmoCollectionWrapper<FullTextStopList>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlPartitionFunctionQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.PartitionFunctions;
                return new SmoCollectionWrapper<PartitionFunction>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlPartitionSchemeQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.PartitionSchemes;
                return new SmoCollectionWrapper<PartitionScheme>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlSearchPropertyListQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.SearchPropertyLists;
                return new SmoCollectionWrapper<SearchPropertyList>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlUserQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.Users;
                return new SmoCollectionWrapper<User>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlSchemaQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.Schemas;
                return new SmoCollectionWrapper<Schema>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlAsymmetricKeyQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.AsymmetricKeys;
                return new SmoCollectionWrapper<AsymmetricKey>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlCertificateQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.Certificates;
                return new SmoCollectionWrapper<Certificate>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlSymmetricKeyQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.SymmetricKeys;
                return new SmoCollectionWrapper<SymmetricKey>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlDatabaseEncryptionKeyQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.DatabaseEncryptionKey;
                return new SqlSmoObject[] { retValue };
            }
            return null;
        }
    }

    internal partial class SqlMasterKeyQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.MasterKey;
                return new SqlSmoObject[] { retValue };
            }
            return null;
        }
    }

    internal partial class SqlDatabaseAuditSpecificationQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.DatabaseAuditSpecifications;
                return new SmoCollectionWrapper<DatabaseAuditSpecification>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlSecurityPolicyQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.SecurityPolicies;
                return new SmoCollectionWrapper<SecurityPolicy>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlDatabaseCredentialQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.DatabaseScopedCredentials;
                return new SmoCollectionWrapper<DatabaseScopedCredential>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlRoleQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.Roles;
                return new SmoCollectionWrapper<DatabaseRole>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlApplicationRoleQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.ApplicationRoles;
                return new SmoCollectionWrapper<ApplicationRole>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlColumnMasterKeyQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.ColumnMasterKeys;
                return new SmoCollectionWrapper<ColumnMasterKey>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlColumnEncryptionKeyQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.ColumnEncryptionKeys;
                return new SmoCollectionWrapper<ColumnEncryptionKey>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlServiceBrokerQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.ServiceBroker;
                return new SqlSmoObject[] { retValue };
            }
            return null;
        }
    }

    internal partial class SqlServiceQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            ServiceBroker parentServiceBroker = context.Parent as ServiceBroker;
            if (parentServiceBroker != null)
            {
                var retValue = parentServiceBroker.Services;
                return new SmoCollectionWrapper<BrokerService>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlContractQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            ServiceBroker parentServiceBroker = context.Parent as ServiceBroker;
            if (parentServiceBroker != null)
            {
                var retValue = parentServiceBroker.ServiceContracts;
                return new SmoCollectionWrapper<ServiceContract>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlQueueQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            ServiceBroker parentServiceBroker = context.Parent as ServiceBroker;
            if (parentServiceBroker != null)
            {
                var retValue = parentServiceBroker.Queues;
                return new SmoCollectionWrapper<ServiceQueue>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlRemoteServiceBindingQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            ServiceBroker parentServiceBroker = context.Parent as ServiceBroker;
            if (parentServiceBroker != null)
            {
                var retValue = parentServiceBroker.RemoteServiceBindings;
                return new SmoCollectionWrapper<RemoteServiceBinding>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlBrokerPriorityQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            ServiceBroker parentServiceBroker = context.Parent as ServiceBroker;
            if (parentServiceBroker != null)
            {
                var retValue = parentServiceBroker.Priorities;
                return new SmoCollectionWrapper<BrokerPriority>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlMessageTypeQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            ServiceBroker parentServiceBroker = context.Parent as ServiceBroker;
            if (parentServiceBroker != null)
            {
                var retValue = parentServiceBroker.MessageTypes;
                return new SmoCollectionWrapper<MessageType>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlExternalDataSourceQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.ExternalDataSources;
                return new SmoCollectionWrapper<ExternalDataSource>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlExternalFileFormatQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.ExternalFileFormats;
                return new SmoCollectionWrapper<ExternalFileFormat>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlProcedureQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.StoredProcedures;
                return new SmoCollectionWrapper<StoredProcedure>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlExtendedStoredProcedureQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Database parentDatabase = context.Parent as Database;
            if (parentDatabase != null)
            {
                var retValue = parentDatabase.ExtendedStoredProcedures;
                return new SmoCollectionWrapper<ExtendedStoredProcedure>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlSubroutineParameterQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            StoredProcedure parentStoredProcedure = context.Parent as StoredProcedure;
            if (parentStoredProcedure != null)
            {
                var retValue = parentStoredProcedure.Parameters;
                return new SmoCollectionWrapper<Parameter>(retValue);
            }
            UserDefinedAggregate parentUserDefinedAggregate = context.Parent as UserDefinedAggregate;
            if (parentUserDefinedAggregate != null)
            {
                var retValue = parentUserDefinedAggregate.Parameters;
                return new SmoCollectionWrapper<Parameter>(retValue);
            }
            UserDefinedFunction parentUserDefinedFunction = context.Parent as UserDefinedFunction;
            if (parentUserDefinedFunction != null)
            {
                var retValue = parentUserDefinedFunction.Parameters;
                return new SmoCollectionWrapper<Parameter>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlPartitionFunctionParameterQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            PartitionFunction parentPartitionFunction = context.Parent as PartitionFunction;
            if (parentPartitionFunction != null)
            {
                var retValue = parentPartitionFunction.PartitionFunctionParameters;
                return new SmoCollectionWrapper<PartitionFunctionParameter>(retValue);
            }
            return null;
        }
    }

    internal partial class SqlBuiltInTypeQuerier: SmoCollectionQuerier
    {
        public override  IEnumerable<SqlSmoObject> Query(SmoQueryContext context)
        {
            Server parentServer = context.Parent as Server;
            if (parentServer != null)
            {
                var retValue = parentServer.SystemDataTypes;
                return new SmoCollectionWrapper<SystemDataType>(retValue);
            }
            return null;
        }
    }

}
