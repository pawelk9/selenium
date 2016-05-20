using Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;

namespace SeleniumExtensions
{
    public static class DriverWait
    {
        private static WebDriverWait browserWait;

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (browserWait == null)
                {
                    throw new NullReferenceException("The WebDriverWait instance was not initialized. You should first call the method Init.");
                }
                return browserWait;
            }
            set
            {
                browserWait = value;
            }
        }

        public static void Init(int seconds)
        {
            LoggerHelper.Logger.DebugFormat("WebDriverWait set to: {0}", seconds);
            BrowserWait = new WebDriverWait(Driver.Browser, TimeSpan.FromSeconds(seconds));
        }

        public static void SetPageLoadTimeout(int seconds)
        {
            LoggerHelper.Logger.DebugFormat("Page load timeout set to: {0}", seconds);
            Driver.Browser.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, seconds));
        }

        public static void SetScriptTimeout(int seconds)
        {
            LoggerHelper.Logger.DebugFormat("Script timeout set to: {0}", seconds);
            Driver.Browser.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(seconds));
        }

        public static void SetImplicitWait(int seconds)
        {
            Driver.Browser.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, seconds));
        }

        public static IWebElement FindElementWait(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                return BrowserWait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }

        public static ReadOnlyCollection<IWebElement> FindElementsWait(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                return BrowserWait.Until(drv => (drv.FindElements(by).Count > 0) ? drv.FindElements(by) : null);
            }
            return driver.FindElements(by);
        }
    }
}
