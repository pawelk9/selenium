using RelevantCodes.ExtentReports;
using System;
using System.IO;

namespace Common
{
    public static class HtmlReport
    {
        private static ExtentReports report;

        private static ExtentReports Report
        {
            get
            {
                if (report == null)
                {
                    throw new NullReferenceException("Report was not initialized.");
                }
                return report;
            }
            set
            {
                report = value;
            }
        }

        private static ExtentTest test;

        public static ExtentTest Test
        {
            get
            {
                if (test == null)
                {
                    throw new NullReferenceException("Test was not initialized.");
                }
                return test;
            }
            set
            {
                test = value;
            }
        }

        public static void Initialize(string testOutputDir, string reportFileName, bool replaceExisting = true, DisplayOrder displayOrder = DisplayOrder.OldestFirst)
        {
            Report = new ExtentReports(Path.Combine(testOutputDir, reportFileName + ".html"), replaceExisting, displayOrder);
            Report.LoadConfig(Path.Combine(testOutputDir, "extentConfig.xml"));
        }

        public static void SetEnvironmentInfo(string key, string value)
        {
            Report.AddSystemInfo(key, value);
        }

        public static void AssignAuthor(params string[] authors)
        {
            foreach (var item in authors)
            {
                Test.AssignAuthor(item);
            }
        }

        public static void AssignCategory(params string[] categories)
        {
            foreach (var item in categories)
            {
                Test.AssignCategory(item);
            }
        }

        public static void AssignCategory(string category)
        {
            Test.AssignCategory(category);
        }

        public static void StartTest(string testName, string testDescription = "")
        {
            Test = Report.StartTest(testName, testDescription);
        }

        public static void EndTest()
        {
            Report.EndTest(Test);
        }

        public static void AddStep(LogStatus stepStatus, string stepName, string details)
        {
            Test.Log(stepStatus, stepName, details);
        }

        public static void AddStep(LogStatus stepStatus, string stepName, Exception exception)
        {
            Test.Log(stepStatus, stepName, exception);
        }

        public static void AddStep(LogStatus stepStatus, string details)
        {
            Test.Log(stepStatus, details);
        }

        public static void AddStep(LogStatus stepStatus, Exception exception)
        {
            Test.Log(stepStatus, exception);
        }

        public static void MakeScreenshot(string dir)
        {
            string img = Test.AddScreenCapture(Path.Combine(dir, "asd.jpg"));
            Test.Log(LogStatus.Info, "Image example: " + img);
        }

        public static void Close()
        {
            Report.Close();
        }

        public static void Write()
        {
            Report.Flush();
        }
    }
}
