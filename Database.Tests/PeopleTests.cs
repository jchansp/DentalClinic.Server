using System;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Database.Tests
{
    [TestClass]
    public class PeopleTests : SqlDatabaseTestClass
    {
        private SqlDatabaseTestActions Database_People_PersistData;
        private SqlDatabaseTestActions Database_People_RetrieveData;

        public PeopleTests()
        {
            InitializeComponent();
        }

        [TestInitialize]
        public void TestInitialize()
        {
            InitializeTest();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            CleanupTest();
        }

        #region Designer support code

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SqlDatabaseTestAction Database_People_Persist_TestAction;
            var resources = new ComponentResourceManager(typeof (PeopleTests));
            SqlDatabaseTestAction Database_People_Retrieve_TestAction;
            ExecutionTimeCondition executionTimeCondition1;
            ExecutionTimeCondition executionTimeCondition2;
            Database_People_PersistData = new SqlDatabaseTestActions();
            Database_People_RetrieveData = new SqlDatabaseTestActions();
            Database_People_Persist_TestAction = new SqlDatabaseTestAction();
            Database_People_Retrieve_TestAction = new SqlDatabaseTestAction();
            executionTimeCondition1 = new ExecutionTimeCondition();
            executionTimeCondition2 = new ExecutionTimeCondition();
            // 
            // Database_People_Persist_TestAction
            // 
            Database_People_Persist_TestAction.Conditions.Add(executionTimeCondition2);
            resources.ApplyResources(Database_People_Persist_TestAction, "Database_People_Persist_TestAction");
            // 
            // Database_People_Retrieve_TestAction
            // 
            Database_People_Retrieve_TestAction.Conditions.Add(executionTimeCondition1);
            resources.ApplyResources(Database_People_Retrieve_TestAction, "Database_People_Retrieve_TestAction");
            // 
            // Database_People_PersistData
            // 
            Database_People_PersistData.PosttestAction = null;
            Database_People_PersistData.PretestAction = null;
            Database_People_PersistData.TestAction = Database_People_Persist_TestAction;
            // 
            // Database_People_RetrieveData
            // 
            Database_People_RetrieveData.PosttestAction = null;
            Database_People_RetrieveData.PretestAction = null;
            Database_People_RetrieveData.TestAction = Database_People_Retrieve_TestAction;
            // 
            // executionTimeCondition1
            // 
            executionTimeCondition1.Enabled = true;
            executionTimeCondition1.ExecutionTime = TimeSpan.Parse("00:00:01");
            executionTimeCondition1.Name = "executionTimeCondition1";
            // 
            // executionTimeCondition2
            // 
            executionTimeCondition2.Enabled = true;
            executionTimeCondition2.ExecutionTime = TimeSpan.Parse("00:00:01");
            executionTimeCondition2.Name = "executionTimeCondition2";
        }

        #endregion

        [TestMethod]
        public void Database_People_Persist()
        {
            var testActions = Database_People_PersistData;
            // Execute the pre-test script
            // 
            Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            var pretestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                var testResults = TestService.Execute(ExecutionContext, PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                var posttestResults = TestService.Execute(PrivilegedContext, PrivilegedContext,
                    testActions.PosttestAction);
            }
        }

        [TestMethod]
        public void Database_People_Retrieve()
        {
            var testActions = Database_People_RetrieveData;
            // Execute the pre-test script
            // 
            Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            var pretestResults = TestService.Execute(PrivilegedContext, PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                var testResults = TestService.Execute(ExecutionContext, PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                var posttestResults = TestService.Execute(PrivilegedContext, PrivilegedContext,
                    testActions.PosttestAction);
            }
        }

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
    }
}