using OpenQA.Selenium;
using SeleniumExtensions;

namespace POM
{
    public abstract class BasePageElementMap
    {
        protected readonly IWebDriver browser;

        public BasePageElementMap()
        {
            browser = Driver.Browser;
        }
    }
}
