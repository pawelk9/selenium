﻿namespace POM.Pages
{
    public class LoginPage : BasePage<LoginPageElementMap>
    {
        public MainPage Login(string username, string password)
        {
            Map.UserNameTextBox.SendKeys(username);
            Map.PasswordTextBox.SendKeys(password);
            Map.LoginButon.Submit();

            return new MainPage();
        }
    }
}
