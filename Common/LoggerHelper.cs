using InfoPanel;
using log4net;
using RelevantCodes.ExtentReports;
using System;
using System.Runtime.CompilerServices;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Common
{
    public static class LoggerHelper
    {
        private static ILog logger;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                {
                    throw new NullReferenceException("Logger was not initialized.");
                }
                return logger;
            }
            private set
            {
                logger = value;
            }
        }

        private static Panel infoPanel;

        public static Panel InfoPanel
        {
            get
            {
                if (infoPanel == null)
                {
                    infoPanel = new Panel();
                }
                return infoPanel;
            }
        }

        public static void InitLogger(Type name)
        {
            Logger = LogManager.GetLogger(name);
        }

        public static void InitLogger([CallerFilePath]string filename = "")
        {
            Logger = LogManager.GetLogger(filename);
        }

        public static void InfoAll(string message)
        {
            InfoPanel.SetMessageText(message);
            Logger.Info(message);
            HtmlReport.AddStep(LogStatus.Info, message);
        }
    }
}
