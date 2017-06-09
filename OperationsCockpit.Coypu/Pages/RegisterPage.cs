using Coypu;
using Zukini.UI.Pages;

public class RegisterPage : BasePage
{
    private const string pageTitle = "Register - Operations Cockpit"; 

    public ElementScope email { get { return Browser.FindField("Email"); } }
    public ElementScope register { get { return Browser.FindButton("Register"); } }
    public ElementScope password { get { return Browser.FindField("Password"); } }
    public ElementScope confirmPassword { get { return Browser.FindField("ConfirmPassword"); } }
    public RegisterPage(BrowserSession browser)
        : base(browser)
    {
    }

    public void AssertCurrentPage()
    {
        base.AssertCurrentPage("STS Register Page", Browser.Title == pageTitle);
    }
}
