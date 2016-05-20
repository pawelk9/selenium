using NUnit.Framework;

namespace POM.Pages
{
    public static class MainPageAsserter
    {
        public static void CheckForm(this MainPage page, string expected)
        {
            Assert.IsTrue(page.Map.FirstNameTextBox.GetAttribute("value").Contains(expected), "Form value does not match");
        }
    }
}
