using BoDi;
using Coypu;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Zukini.UI.Steps;

namespace OperationsCockpit.Coypu
{
    [Binding]
    public class LoginSteps : UISteps
    {
        private string _userIdentifier;
        public LoginSteps(IObjectContainer objectContainer)
        : base(objectContainer)
        {
        }

        [Given(@"I am at the login page")]
        public void GivenIAmAtTheLoginPage()
        {
            Browser.Visit(Properties.Settings.Default.OperationsCockpitStartUrl);
            var thisPage = new LoginPage(Browser);
            thisPage.AssertCurrentPage();
        }
        [When(@"I enter the '(.*)' username and password")]
        public void WhenIEnterTheUsernameAndPassword(string UserIdentifier)
        {
            _userIdentifier = UserIdentifier;
            var loginPage = FillInCredentials(Browser, _userIdentifier);
        }

        private static LoginPage FillInCredentials(BrowserSession Browser, string UserIdentifier)
        {
            string _username = Properties.Settings.Default[UserIdentifier + "UserName"].ToString();
            string _password = Properties.Settings.Default[UserIdentifier + "UserPassword"].ToString();

            var loginPage = new LoginPage(Browser);
            loginPage.email.FillInWith(_username);
            loginPage.password.FillInWith(_password);
            return loginPage;
        }

        public static void LoginAsUser(BrowserSession Browser, string UserIdentifier)
        {
            Browser.Visit(Properties.Settings.Default.OperationsCockpitStartUrl);
            var thisPage = FillInCredentials(Browser,UserIdentifier);
            thisPage.logIn.Click();
            if (Browser.HasContent(LoginPage.InvalidUserString))
            {
                RegisterUser(Browser, UserIdentifier);
            }
        }

        public static void RegisterUser(BrowserSession Browser, string UserIdentifier)
        {
            string _username = Properties.Settings.Default[UserIdentifier + "UserName"].ToString();
            string _password = Properties.Settings.Default[UserIdentifier + "UserPassword"].ToString();

            Browser.Visit(Properties.Settings.Default.OperationsCockpitRegisterUrl);
            var registerPage = new RegisterPage(Browser);
            registerPage.email.FillInWith(_username);
            registerPage.password.FillInWith(_password);
            registerPage.confirmPassword.FillInWith(_password);
            registerPage.register.Click();
        }


        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            var thisPage = new LoginPage(Browser);
            thisPage.logIn.Click();
        }

        [Then(@"I should see '(.*)' in the results")]
        public void ThenIShouldSeeInTheResults(string ExpectedValue)
        {
            if (Browser.HasContent(LoginPage.InvalidUserString))
            {
                RegisterUser(Browser, _userIdentifier);
            }
            Assert.IsTrue(Browser.HasContent(ExpectedValue));
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Browser.ClickLink("Log off");
            Browser.Dispose();
        }

    }
}
