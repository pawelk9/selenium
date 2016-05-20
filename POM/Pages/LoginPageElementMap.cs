using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace POM.Pages
{
    public partial class LoginPage : BasePage
    {
        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement UserNameTextBox { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement PasswordTextBox { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement LoginButon { get; set; }
    }
}
