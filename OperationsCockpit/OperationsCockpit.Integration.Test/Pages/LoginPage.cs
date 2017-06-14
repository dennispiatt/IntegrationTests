using Coypu;
using Zukini.UI.Pages;

public class LoginPage : BasePage
{
    private const string pageTitle = "Log in - Operations Cockpit";
    public static string InvalidUserString = "Invalid username or password.";
    public ElementScope email { get { return Browser.FindField("Email"); } }
    public ElementScope forgotYourPassword { get { return Browser.FindLink("/OperationsCockpit_STS/Account/ForgotPassword"); } }
    public ElementScope password { get { return Browser.FindField("Password"); } }
    public ElementScope logIn { get { return Browser.FindButton("Log in"); } }
        public LoginPage(BrowserSession browser)
        : base(browser)
    {
    }

    public void AssertCurrentPage()
    {
        base.AssertCurrentPage("STS Login Page", Browser.Title == pageTitle);
    }
}
