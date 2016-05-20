using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtensions;

namespace POM
{
    public abstract class BasePageElementMap
    {
        protected readonly IWebDriver browser;
        protected readonly WebDriverWait browserWait;

        public BasePageElementMap()
        {
            browser = Driver.Browser;
            browserWait = Driver.BrowserWait;
        }

        public void SwitchToDefaultContent()
        {
            browser.SwitchTo().DefaultContent();
        }
    }
}
