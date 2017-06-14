using BoDi;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Zukini.UI.Steps;

namespace OperationsCockpit.Integration.Test.Steps
{
    [Binding]
    public class AgreementSteps : UISteps
    {
        public AgreementSteps(IObjectContainer objectContainer)
        : base(objectContainer)
        {
        }

        [When(@"I execute Agreement Acceptance sequence")]
        public void WhenIExecuteAgreementAcceptanceSequence()
        {
            var thisPage = new AgreementPage(Browser);
            if (thisPage.AgreementStatus() == "Pending")
            {
                thisPage.AgreementAcceptanceOption("true").Click();
                thisPage.AgreementAcceptanceButton("Save").Click();
            }
            else if (thisPage.AgreementStatus() == "Accepted") {
                //do nothing as it is already accepted
                Assert.Ignore();
            }
            else //Rejected
            {
                ScenarioContext.Current.Pending();
            }
        }
    }
}
