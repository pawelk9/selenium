using NUnit.Framework;
using POM.Pages;
using SeleniumExtensions;

/*
    Architecture:
    1. Tests
    2. Framework (POM)
    3. Selenium
    4. SUT

    - design smoke tests first, best ROI
    - design freamework along the smoke tests

*/

namespace SeleniumTests
{
    [TestFixture]
    public class SeleniumTest : TestBase
    {
        [Test]
        public void DemoTest()
        {
            Driver.Navigate("http://executeautomation.com/demosite/Login.html");

            var loginPage = new LoginPage();
            var mainPage = loginPage.Login("pawel", "jowjow");

            mainPage.FillForm("PK", "Pawel", "Kozlowski");
            mainPage.CheckForm("Pawel");
        }

        [Test]
        public void DemoTest2()
        {
            Driver.Navigate("http://executeautomation.com/demosite/Login.html");

            var loginPage = new LoginPage();
            var mainPage = loginPage.Login("dupa", "jana");
            mainPage.FillForm("DD", "Jan", "Dupowski");
            mainPage.CheckForm("Pawel");
        }
    }

}
