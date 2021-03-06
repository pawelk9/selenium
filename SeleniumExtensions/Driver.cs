﻿using Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Drawing.Imaging;

namespace SeleniumExtensions
{
    public static class Driver
    {
        private static IWebDriver browser;

        public static IWebDriver Browser
        {
            get
            {
                if (browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                }
                return browser;
            }
            private set
            {
                browser = value;
            }
        }

        private static WebDriverWait browserWait;

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (browserWait == null || browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method StartBrowser.");
                }
                return browserWait;
            }
            private set
            {
                browserWait = value;
            }
        }

        public static void StartBrowser(BrowserType browserType = BrowserType.Firefox, int pageLoadTimeout = 10, int waitTimeout = 30, bool maximizeWindow = true)
        {
            HtmlReport.SetEnvironmentInfo("Browser", browserType.ToString());
            LoggerHelper.InfoAll(string.Format("Start {0} browser", browserType.ToString()));

            switch (browserType)
            {
                case BrowserType.Firefox:
                    Browser = new FirefoxDriver();
                    break;
                case BrowserType.InternetExplorer:
                    break;
                case BrowserType.Chrome:
                    break;
                default:
                    break;
            }

            Browser.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, pageLoadTimeout));
            BrowserWait = new WebDriverWait(Browser, TimeSpan.FromSeconds(waitTimeout));

            if (maximizeWindow)
            {
                Browser.Manage().Window.Maximize();
            }
        }

        public static void StopBrowser()
        {
            LoggerHelper.InfoAll("Close browser");
            Browser.Quit();
            Browser = null;
            BrowserWait = null;
        }

        public static void Navigate(string url)
        {
            LoggerHelper.InfoAll(string.Format("Navigate to '{0}'", url));
            Browser.Navigate().GoToUrl(url);
        }

        public static void TakeFullScreenshot(string filename)
        {
            Screenshot screenshot = ((ITakesScreenshot)Browser).GetScreenshot();
            screenshot.SaveAsFile(filename, ImageFormat.Png);
            throw new NotImplementedException();
        }

        public static void AddCookie(string key, string value)
        {
            Cookie cookie = new Cookie(key, value);
            Browser.Manage().Cookies.AddCookie(cookie);
        }

        public static void GetAllCookies()
        {
            var cookies = Browser.Manage().Cookies.AllCookies;
            foreach (var currentCookie in cookies)
            {
                throw new NotImplementedException();
            }
        }

        public static void GetCookie(string cookieName)
        {
            var myCookie = Browser.Manage().Cookies.GetCookieNamed(cookieName);
        }

        public static void DeleteAllCookies()
        {
            LoggerHelper.Logger.Debug("Delete all cookies");
            Browser.Manage().Cookies.DeleteAllCookies();
        }

        public static void DeleteCookie(string cookieName)
        {
            Browser.Manage().Cookies.DeleteCookieNamed(cookieName);
        }

        private static void SetImplicitWait(int seconds)
        {
            Browser.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, seconds));
        }
    }

    public enum BrowserType
    {
        Firefox,
        InternetExplorer,
        Chrome
    }
}
