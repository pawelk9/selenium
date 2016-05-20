using Common;

namespace POM.Pages
{
    public partial class MainPage
    {
        public void FillForm(string initials, string firstName, string middleName)
        {
            LoggerHelper.InfoAll("Fill form and click 'Save' button");

            InitialTextBox.SendKeys(initials);
            FirstNameTextBox.SendKeys(firstName);
            MiddleNameTextBox.SendKeys(middleName);
            SaveButton.Click();
        }
    }
}
