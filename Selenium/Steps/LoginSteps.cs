using TechTalk.SpecFlow;

namespace SeleniumTests.Steps
{
    [Binding]
    public sealed class LoginSteps
    {

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {

        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
        }
    }
}
