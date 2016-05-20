using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace POM.Pages
{
    public partial class MainPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement TitleId { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement InitialTextBox { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement FirstNameTextBox { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement MiddleNameTextBox { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement SaveButton { get; set; }
    }
}
