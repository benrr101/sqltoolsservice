//------------------------------------------------------------------------------
// <copyright file="RunEnvironmentInfo.cs" company="Microsoft">
//         Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.IO;
using System.Reflection;
using Microsoft.SqlTools.ServiceLayer.Test.Commons;
using Microsoft.SqlTools.ServiceLayer.Utility;

namespace Microsoft.SqlTools.ServiceLayer.Test.Common
{
    public class RunEnvironmentInfo
    {
        private static string cachedTestFolderPath;

        public static bool IsLabMode()
        {
            string bvtLabRoot = Environment.GetEnvironmentVariable(Consts.BVTLocalRoot);
            if (String.IsNullOrEmpty(bvtLabRoot))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Location of all test data (baselines, etc).
        /// </summary>
        /// <returns>The full path to the test data directory</returns>
        public static string GetTestDataLocation()
        {
            string testFolderPath;
     
            if (IsLabMode())
            {
                string testPath = @"test\Microsoft.SqlTools.ServiceLayer.Test";
                testFolderPath = Path.Combine(Environment.GetEnvironmentVariable(Consts.TestFileLocation), testPath);
                Console.WriteLine("----- ACTUALLY LAB MODE ------");
                Console.WriteLine(testFolderPath);
            }
            else
            {
                if (cachedTestFolderPath != null)
                {
                    testFolderPath = cachedTestFolderPath;
                }
                else
                {
                    string defaultPath = Path.Combine(typeof(Scripts).GetTypeInfo().Assembly.Location, @"..\..\..\..\..");
                    testFolderPath = Path.Combine(defaultPath, @"Microsoft.SqlTools.ServiceLayer.Test");
                    cachedTestFolderPath = testFolderPath;
                }
                Console.WriteLine("----- ACTUALLY LOCAL MODE ------");
                Console.WriteLine(testFolderPath);
            }
            return testFolderPath;
        }

    }
}