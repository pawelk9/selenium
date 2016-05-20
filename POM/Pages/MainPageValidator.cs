using NUnit.Framework;

namespace POM.Pages
{
    public class MainPageValidator : BasePageValidator<MainPageElementMap>
    {
        public void CheckForm(string expected)
        {
            Assert.IsTrue(Map.FirstNameTextBox.GetAttribute("value").Contains(expected), "Fail");
        }
    }
}
