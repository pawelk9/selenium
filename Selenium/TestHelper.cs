using Common;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using RelevantCodes.ExtentReports;

namespace SeleniumTests
{
    public static class TestHelper
    {
        public static void WriteTestOutcome()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var message = TestContext.CurrentContext.Result.Message;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace) ? "" : TestContext.CurrentContext.Result.StackTrace;

            LogStatus htmlStatus;
            switch (status)
            {
                case TestStatus.Inconclusive:
                    htmlStatus = LogStatus.Unknown;
                    break;
                case TestStatus.Skipped:
                    htmlStatus = LogStatus.Skip;
                    break;
                case TestStatus.Passed:
                    htmlStatus = LogStatus.Pass;
                    break;
                case TestStatus.Failed:
                    htmlStatus = LogStatus.Fail;
                    break;
                default:
                    htmlStatus = LogStatus.Unknown;
                    break;
            }

            LoggerHelper.Logger.InfoFormat("Test status: {0}", status);

            if (!string.IsNullOrEmpty(stacktrace))
            {
                LoggerHelper.Logger.ErrorFormat("Stacktrace: {0}", stacktrace);
                HtmlReport.AddStep(LogStatus.Warning, string.Format("Stacktrace: {0}", stacktrace));
            }

            if (message != null)
            {
                HtmlReport.AddStep(LogStatus.Warning, string.Format("Message: {0}", message));
            }

            HtmlReport.AddStep(htmlStatus, string.Format("Test status: {0}", status.ToString()));
        }
    }
}
