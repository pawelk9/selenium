using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.ComponentModel;
using System.Linq;

namespace SeleniumExtensions
{
    public static class GetMethods
    {
        public static string GetAllPageText(this IWebDriver driver)
        {
            return driver.FindElement(By.TagName("body")).Text;
        }

        public static string GetTextFromDropdown(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }

        public static T GetAttributeAsType<T>(this IWebElement element, string attributeName)
        {
            string value = element.GetAttribute(attributeName) ?? string.Empty;
            return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(value);
        }
    }
}
