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

        [Given(@"Add an Integration for '(.*)','(.*)','(.*)','(.*)','(.*)','(.*)','(.*)','(.*)','(.*)','(.*)','(.*)','(.*)','(.*)'")]
        public void GivenAddAnIntegrationFor(string SystemType, string Vendor, string System, string Year, string LocationType, string UserId, string UserPassword, string ScheduleType, string StartDate, string StartTimeHour, string StartTimeMinute, string StartTimeAMPM, string NotificationEmail)
        {
            var thisPage = new InboundIntegrationPage(Browser);
            thisPage.SystemType.SelectOption(SystemType);
            thisPage.Vendor.SelectOption(Vendor);
            thisPage.System.SelectOption(System);
            if (Year != "<UseDefault>") thisPage.Year.SelectOption(Year);
            switch (LocationType)
            {
                case "Local":
                    thisPage.Source.LocationTypeLocal.Click();
                    break;
                case "Remote":
                    thisPage.Source.LocationTypeRemote.Click();
                    break;
                default:
                    break;
            }
            if (UserId != "<UseDefault>") thisPage.Source.UserId.FillInWith(UserId);
            thisPage.Source.UserPassword.FillInWith(UserPassword);
            if (ScheduleType != "<UseDefault>") thisPage.Schedule.ScheduleType.SelectOption(ScheduleType);
            thisPage.Schedule.StartDate.FillInWith(StartDate);
            thisPage.Schedule.StartTimeHour.SelectOption(StartTimeHour);
            thisPage.Schedule.StartTimeMinute.SelectOption(StartTimeMinute);
            thisPage.Schedule.StartTimeAMPM.SelectOption(StartTimeAMPM);
            thisPage.NotificationEmail.FillInWith(NotificationEmail);
        }

        public static void NavigateToPage(BrowserSession Browser, string IsdName, string DistrictName, string IntegrationName)
        {
            DistrictSteps.NavigateToPage(Browser, IsdName, DistrictName);
            var thisPage = new DistrictPage(Browser);
            thisPage.IntegrationLink(IntegrationName, "Inbound Integrations").Click();
            var landingPage = new InboundIntegrationPage(Browser);
            landingPage.AssertCurrentPage();
        }

    }
}
