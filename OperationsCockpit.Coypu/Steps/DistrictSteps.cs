using BoDi;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Zukini.UI.Steps;

namespace OperationsCockpit.Coypu.Steps
{
    [Binding]
    public class DistrictSteps : UISteps
    {
        public DistrictSteps(IObjectContainer objectContainer)
        : base(objectContainer)
        {
        }

        [Given(@"I am on the '(.*)' District Page")]
        public void GivenIAmOnThedistrictPage(string DistrictName)
        {
            var thisPage = new DistrictPage(Browser);
            thisPage.AssertCurrentPage(DistrictName);
        }

        [Given(@"I click on the '(.*)' Menu Button")]
        public void GivenIClickOnTheMenuButton(string ButtonDisplayText)
        {
            var thisPage = new DistrictPage(Browser);
            thisPage.MenuButton(ButtonDisplayText).Click();
        }

        [When(@"I click on '(.*)' Menu Option on the '(.*)' Menu Button")]
        [Given(@"I click on '(.*)' Menu Option on the '(.*)' Menu Button")]
        public void WhenIClickOn(string OptionDisplayText, string ButtonDisplayText)
        {
            var thisPage = new DistrictPage(Browser);
            thisPage.MenuButtonOption(ButtonDisplayText, OptionDisplayText).Click();
        }

        [Then(@"I should be on the Agreement List page for '(.*)'")]
        public void ThenIShouldBeOnTheAgreementListPageFor(string DistrictName)
        {
            var landingPage = new AgreementListPage(Browser);
            landingPage.AssertCurrentPage(DistrictName);
        }

        [When(@"I click on the '(.*)' link in the '(.*)' section")]
        public void WhenIClickOnTheLinkInTheSection(string LinkDisplayText, string SectionDisplayText)
        {
            var thisPage = new DistrictPage(Browser);
            thisPage.IntegrationLink(LinkDisplayText, SectionDisplayText).Click();
        }

        [Then(@"I should be on the Inbound Integration page for '(.*)'")]
        public void ThenIShouldBeOnTheInboundIntegrationPageFor(string DisplayText)
        {
            var landingPage = new InboundIntegrationPage(Browser);
            landingPage.AssertCurrentPage(DisplayText);
        }

        [Given(@"There is not already an item named '(.*)' in the '(.*)' section")]
        public void GivenThereIsNotAlreadyAnItemNamedInTheSection(string LinkDisplayText, string SectionDisplayText)
        {
            var thisPage = new DistrictPage(Browser);
            if (thisPage.IntegrationLink(LinkDisplayText, SectionDisplayText).Exists())
            {
                Assert.Ignore(string.Format("{0} already exists in {1}", LinkDisplayText, SectionDisplayText));
            } 
        }


    }
}
