using Common;
using NUnit.Framework;
using SeleniumExtensions;
using System;

namespace SeleniumTests
{
    public abstract class TestBase
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            LoggerHelper.InitLogger();
            HtmlReport.Initialize(TestContext.CurrentContext.WorkDirectory, TestContext.CurrentContext.Test.ClassName, true);
        }

        [SetUp]
        public void SetUp()
        {
            HtmlReport.StartTest(TestContext.CurrentContext.Test.Name);
            Driver.StartBrowser(BrowserType.Firefox);
            Driver.DeleteAllCookies();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.StopBrowser();
            TestHelper.WriteTestOutcome();
            HtmlReport.EndTest();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            HtmlReport.Write();
            HtmlReport.Close();
            LoggerHelper.InfoPanel.Close();
        }
    }
}
