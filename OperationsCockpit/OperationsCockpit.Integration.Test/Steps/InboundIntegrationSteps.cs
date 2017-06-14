using BoDi;
using Coypu;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Zukini.UI.Steps;

namespace OperationsCockpit.Integration.Test.Steps
{
    [Binding]
    public class InboundIntegrationSteps : UISteps
    {
        public InboundIntegrationSteps(IObjectContainer objectContainer)
        : base(objectContainer)
        {
        }

        [Given(@"I navigate to integration '(.*)' for district '(.*)' in ISD '(.*)' Inbound Integration Page")]
        public void GivenINavigateToIntegrationForDistrictInISDInboundIntegrationPage(string IntegrationName, string DistrictName, string IsdName)
        {
            NavigateToPage(Browser,IsdName,DistrictName, IntegrationName);
        }
        
        [Given(@"I Select Run At Next Cycle")]
        public void GivenSelectRunAtNextCycle()
        {
            var thisPage = new InboundIntegrationPage(Browser);
            thisPage.Schedule.RunAtNextCycle();
        }
        
        [When(@"I Submit the form")]
        public void WhenISubmitTheForm()
        {
            var thisPage = new InboundIntegrationPage(Browser);
            thisPage.Submit();
        }

        public static void NavigateToPage(BrowserSession Browser, string IsdName, string DistrictName, string IntegrationName)
        {
            DistrictSteps.NavigateToPage(Browser, IsdName, DistrictName);
            var thisPage = new DistrictPage(Browser);
            thisPage.IntegrationLink(IntegrationName, "Inbound Integrations").Click();
            var landingPage = new InboundIntegrationPage(Browser);
            landingPage.AssertCurrentPage(IntegrationName);
        }

    }
}
