using TechTalk.SpecFlow;

namespace BehaviorDrivenDevelopment.Tests.Behavior.Steps;

[Binding]
public class LoggedInDiscountSteps
{
    [Given(@"a user that is not logged in")]
    public void GivenAUserThatIsNotLoggedIn()
    {
        ScenarioContext.StepIsPending();
    }

    [Given(@"an empty basket")]
    public void GivenAnEmptyBasket()
    {
        ScenarioContext.StepIsPending();
    }

    [When(@"a (.*) that costs (.*) GBP is added to the basket")]
    public void WhenAtShirtThatCostsGbpIsAddedToTheBasket(string itemName, decimal price)
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"the basket value is (.*) GBP")]
    public void ThenTheBasketValueIsGbp(decimal basketValue)
    {
        ScenarioContext.StepIsPending();
    }

    [Given(@"a user that is logged in")]
    public void GivenAUserThatIsLoggedIn()
    {
        ScenarioContext.StepIsPending();
    }

    [When(@"a dress that costs (.*) GBP is added to the basket")]
    public void WhenADressThatCostsGbpIsAddedToTheBasket(decimal price)
    {
        ScenarioContext.StepIsPending();
    }
}