using Common;

namespace POM.Pages
{
    public partial class LoginPage
    {
        public MainPage Login(string username, string password)
        {
            LoggerHelper.InfoAll(string.Format("Type '{0}' and '{1}' and login", username, password));

            UserNameTextBox.SendKeys(username);
            PasswordTextBox.SendKeys(password);
            LoginButon.Submit();

            return new MainPage();
        }
    }
}
