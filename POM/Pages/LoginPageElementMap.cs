using OpenQA.Selenium;

namespace POM.Pages
{
    public class LoginPageElementMap : BasePageElementMap
    {

        public IWebElement UserNameTextBox
        {
            get
            {
                return browser.FindElement(By.Name("UserName"));
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
