using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtensions;

namespace POM
{
    public abstract class BasePage
    {
        protected IWebDriver browser;

        public BasePage()
        {
            browser = Driver.Browser;
            PageFactory.InitElements(browser, this);
        }
    }
}
