﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Database.Tests
{
    [TestClass()]
    public class EntitiesTests : SqlDatabaseTestClass
    {

        public EntitiesTests()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Database_PersistEntities_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntitiesTests));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExecutionTimeCondition executionTimeCondition1;
            this.Database_PersistEntitiesData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            Database_PersistEntities_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            executionTimeCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExecutionTimeCondition();
            // 
            // Database_PersistEntitiesData
            // 
            this.Database_PersistEntitiesData.PosttestAction = null;
            this.Database_PersistEntitiesData.PretestAction = null;
            this.Database_PersistEntitiesData.TestAction = Database_PersistEntities_TestAction;
            // 
            // Database_PersistEntities_TestAction
            // 
            Database_PersistEntities_TestAction.Conditions.Add(executionTimeCondition1);
            resources.ApplyResources(Database_PersistEntities_TestAction, "Database_PersistEntities_TestAction");
            // 
            // executionTimeCondition1
            // 
            executionTimeCondition1.Enabled = true;
            executionTimeCondition1.ExecutionTime = System.TimeSpan.Parse("00:00:30");
            executionTimeCondition1.Name = "executionTimeCondition1";
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion


        [TestMethod()]
        public void Database_PersistEntities()
        {
            SqlDatabaseTestActions testActions = this.Database_PersistEntitiesData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions Database_PersistEntitiesData;
    }
}
