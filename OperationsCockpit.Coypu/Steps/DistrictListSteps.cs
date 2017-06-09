using BoDi;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Zukini.UI.Steps;

namespace OperationsCockpit.Coypu
{
    [Binding]
    class DistrictListSteps : UISteps
    {
        public DistrictListSteps(IObjectContainer objectContainer)
        : base(objectContainer)
        {
        }

        [Given(@"I am logged in as '(.*)'")]
        public void GivenIAmLoggedInAsWithOnThePage(string UserIdentifier)
        {
            LoginSteps.LoginAsUser(Browser, UserIdentifier);
        }

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            var thisPage = new DistrictListPage(Browser);
            thisPage.AssertCurrentPage();
        }

        [Given(@"the '(.*)' tab is not expanded")]
        public void GivenTheTabIsNotExpanded(string IsdName)
        {
            var thisPage = new DistrictListPage(Browser);
            var testDistrict = thisPage.IsdTab(IsdName);
        }


        [When(@"I click on the '(.*)' tab")]
        public void WhenIClickOnTheTab(string IsdName)
        {
            var thisPage = new DistrictListPage(Browser);
            thisPage.IsdTab(IsdName).Click();
        }

        [Then(@"I should see the '(.*)' link")]
        public void ThenIShouldSeeTheLink(string DistrictName)
        {
            var thisPage = new DistrictListPage(Browser);
            Assert.IsFalse(thisPage.DistrictLink(DistrictName).Disabled);
        }

        [Given(@"the '(.*)' tab is expanded")]
        public void GivenTheTabIsExpanded(string IsdName)
        {
            var thisPage = new DistrictListPage(Browser);
            thisPage.IsdTab(IsdName).Click();
        }

        [When(@"I click on the '(.*)' link")]
        [Given(@"I click on the '(.*)' link")]
        public void WhenIClickOnTheLink(string DistrictName)
        {
            var thisPage = new DistrictListPage(Browser);
            thisPage.DistrictLink(DistrictName).Click(); 
        }

        [Then(@"I should be on the District page for '(.*)'")]
        public void ThenIShouldBeOnTheDistrictPageFor(string DistrictName)
        {
            var landingPage = new DistrictPage(Browser);
            landingPage.AssertCurrentPage(DistrictName);
        }

    }
}
