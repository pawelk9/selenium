using OpenQA.Selenium;

namespace SeleniumExtensions
{
    public static class HasMethods
    {
        public static bool HasElement(this IWebDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            return true;
        }
    }
}
