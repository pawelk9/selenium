using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumExtensions
{
    public static class SetMethods
    {
        public static void SendKeys(this IWebElement element, string text, bool clearFirst)
        {
            if (clearFirst) element.Clear();
            element.SendKeys(text);
        }

        public static void SelectDropDown(this IWebElement element, string text)
        {
            new SelectElement(element).SelectByText(text);
        }

        public static void SetAttribute(this IWebElement element, string attributeName, string value)
        {
            IWrapsDriver wrappedElement = element as IWrapsDriver;
            if (wrappedElement == null)
                throw new ArgumentException("element", "Element must wrap a web driver");

            IWebDriver driver = wrappedElement.WrappedDriver;
            IJavaScriptExecutor javascript = driver as IJavaScriptExecutor;
            if (javascript == null)
                throw new ArgumentException("element", "Element must wrap a web driver that supports javascript execution");

            javascript.ExecuteScript("arguments[0].setAttribute(arguments[1], arguments[2])", element, attributeName, value);
        }
    }
}
