using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessRulesEngine;
using BusinessRulesEngine.Models;
using BusinessRulesEngine.Interfaces;
using BusinessRulesEngine.Notification;

namespace Testing
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
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
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Test_PhysicalProducts()
        {
            IPayment physicalProducts = new PhysicalProducts();
            bool res = physicalProducts.PackingSlip();
            Assert.AreEqual(res, true); 
        }

        [TestMethod]
        public void Test_Books()
        {
            IPayment book = new Books();
            bool res = book.PackingSlip();
            Assert.AreEqual(res, true); 
        }
        [TestMethod]
        public void Test_Membership()
        {
            IActivate iActivate = new Membership();
            bool res = iActivate.Activate();
            Assert.AreEqual(res, true); 
        }
        [TestMethod]
        public void Test_UpgradeToMembership()
        {
            IUpgrade iUpgrade = new UpgradeMembership();
            bool res = iUpgrade.Upgrade();
            Assert.AreEqual(res, true);
        }

        [TestMethod]
        public void Test_MembershipWithIEmailService()
        {
            IEmailService iEmailService = new Membership();
            bool res = iEmailService.SendMail();
            Assert.AreEqual(res, true);
        }
        [TestMethod]
        public void Test_UpgradeMembershipWithIEmailService()
        {
            IEmailService iEmailService = new UpgradeMembership();
            bool res = iEmailService.SendMail();
            Assert.AreEqual(res, true);
        }

        [TestMethod]
        public void Test_MembershipORUpgradeWithEmailNotificationMembership()
        {
            EmailNotification emailNotification = new EmailNotification(new Membership());
            bool res = emailNotification.DoEmailNotify();
            Assert.AreEqual(res, true);
        }

        [TestMethod]
        public void Test_MembershipORUpgradeWithEmailNotificationUpgradeMembership()
        {
            EmailNotification emailNotification = new EmailNotification(new UpgradeMembership());
            bool res = emailNotification.DoEmailNotify();
            Assert.AreEqual(res, true);
        }

        [TestMethod]
        public void Test_LearningToSki()
        {
            IPayment iPayment = new LearningToSki();
            bool res = iPayment.PackingSlip();
            Assert.AreEqual(res, true);
        }

        [TestMethod]
        public void Test_PhysicalProductsORBooksPhysicalProducts()
        {
            IPayment iPayment = new PhysicalProducts();
            bool res = iPayment.PackingSlip();
            Assert.AreEqual(res, true);
        }

        [TestMethod]
        public void Test_PhysicalProductsORBooksBooks()
        {
            IPayment iPayment = new Books();
            bool res = iPayment.PackingSlip();
            Assert.AreEqual(res, true);
        }
        [TestMethod]
        public void Test_AgentCommissionNotificationPhysicalProducts()
        {
            AgentCommissionNotification agentCommissionNotification = new AgentCommissionNotification(new PhysicalProducts());
            bool res = agentCommissionNotification.DoAgentCommissionNotify();
            Assert.AreEqual(res, true);
        }
        [TestMethod]
        public void Test_AgentCommissionNotificationBooks()
        {
            AgentCommissionNotification agentCommissionNotification = new AgentCommissionNotification(new Books());
            bool res = agentCommissionNotification.DoAgentCommissionNotify();
            Assert.AreEqual(res, true);
        }

        [TestMethod]
        public void Test_PhysicalProductsAgentCommission()
        {
            IAgentCommission iAgentCommission = new PhysicalProducts();
            bool res = iAgentCommission.AgentCommission();
            Assert.AreEqual(res, true);
        }
        [TestMethod]
        public void Test_BooksAgentCommission()
        {
            IAgentCommission iAgentCommission = new Books();
            bool res = iAgentCommission.AgentCommission();
            Assert.AreEqual(res, true);
        }
    }
}
