using BoDi;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Zukini.UI.Steps;

namespace OperationsCockpit.Integration.Test.Steps
{
    [Binding]
    public class AgreementListSteps : UISteps
    {
        public AgreementListSteps(IObjectContainer objectContainer)
        : base(objectContainer)
        {
        }
    
        [Given(@"I am on the '(.*)' Agreement List Page")]
        public void GivenIAmOnTheAgreementListPage(string DistrictName)
        {
            var thisPage = new AgreementListPage(Browser);
            thisPage.AssertCurrentPage(DistrictName);
        }

        [Given(@"I click on the View Agreement Link for '(.*)'")]
        [When(@"I click on the View Agreement Link for '(.*)'")]
        public void WhenIClickOnTheViewAgreementLinkFor(string AgreementName)
        {
            var thisPage = new AgreementListPage(Browser);
            thisPage.AgreementLink(AgreementName).Click();
        }

        [Then(@"I should be on the Agreement page for '(.*)'")]
        [Given(@"I am on the '(.*)' Agreement page")]
        public void ThenIShouldBeOnTheAgreementPageFor(string AgreementName)
        {
            var landingPage = new AgreementPage(Browser);
            landingPage.AssertCurrentPage(AgreementName);
        }
    }
}
