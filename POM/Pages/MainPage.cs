namespace POM.Pages
{
    public class MainPage : BasePage<MainPageElementMap>
    {
        public void FillForm(string initials, string firstName, string middleName)
        {
            Map.InitialTextBox.SendKeys(initials);
            Map.FirstNameTextBox.SendKeys(firstName);
            Map.MiddleNameTextBox.SendKeys(middleName);
            Map.SaveButton.Click();
        }
    }
}
