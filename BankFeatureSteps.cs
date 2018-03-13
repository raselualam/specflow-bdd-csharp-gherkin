using System;
using TechTalk.SpecFlow;

namespace Specflow
{
    [Binding]
    public class BankFeatureSteps
    {
        [Given(@"I have \$(.*) in my account")]
        public void GivenIHaveInMyAccount(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I entered PIN as (.*)")]
        public void GivenIEnteredPINAs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I withdraw \$(.*) from ATM")]
        public void WhenIWithdrawFromATM(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"My balance should be \$(.*)")]
        public void ThenMyBalanceShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
