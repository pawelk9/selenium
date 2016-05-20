using OpenQA.Selenium;

namespace POM.Pages
{
    public class MainPageElementMap : BasePageElementMap
    {

        public IWebElement TitleId
        {
            get
            {
                return browser.FindElement(By.Id("TitleId"));
            }
        }

        public IWebElement InitialTextBox
        {
            get
            {
                return browser.FindElement(By.Name("Initial"));
            }
        }

        public IWebElement FirstNameTextBox
        {
            get
            {
                return browser.FindElement(By.Name("FirstName"));
            }
        }

        public IWebElement MiddleNameTextBox
        {
            get
            {
                return browser.FindElement(By.Name("MiddleName"));
            }
        }

        public IWebElement SaveButton
        {
            get
            {
                return browser.FindElement(By.Name("Save"));
            }
        }
    }
}
