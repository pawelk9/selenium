using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtensions;

namespace POM.Pages
{
    public class LoginPageElementMap : BasePageElementMap
    {
        public IWebElement UserNameTextBox
        {
            get
            {
                return browser.FindElementWait(By.Name("Dupa"), 5);
            }
        }

        public IWebElement PasswordTextBox
        {
            get
            {
                return browser.FindElement(By.Name("Password"));
            }
        }

        public IWebElement LoginButon
        {
            get
            {
                return browser.FindElement(By.Name("Login"));
            }
        }
    }
}
