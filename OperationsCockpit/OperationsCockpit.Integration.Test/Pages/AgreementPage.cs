using Coypu;
using Zukini.UI.Pages;
using System.Linq;

public class AgreementPage : BasePage
{
    private const string pageTitle = "Agreement - Operations Cockpit";
    public AgreementPage(BrowserSession browser)
        : base(browser)
    {
    }

    public string AgreementStatus()
    {
        var statusString = Browser.FindCss("body > div.container.body-content > div.container > p").Text;
        var regEx = new System.Text.RegularExpressions.Regex("(\\w*)(?:\\son\\s\\d{1,2}/\\d{1,2}/\\d{4}\\sby\\s[A-Za-z ]*)?");
        return regEx.Match(statusString).Groups[1].Captures[0].Value;
    }

    public ElementScope AgreementAcceptanceOption(string Value)
    {
        return Browser.FindCss(string.Format("#Accepted[value={0}]",Value));
    }

    public ElementScope AgreementAcceptanceButton(string DisplayText)
    {
        return Browser.FindCss("#buttonRow > a", text: DisplayText);
    }

    public void AssertCurrentPage()
    {
        base.AssertCurrentPage("Agreement", Browser.Title == pageTitle);
    }

    public void AssertCurrentPage(string AgreementName)
    {
        base.AssertCurrentPage("Agreement", Browser.Title == pageTitle && Browser.HasContent(AgreementName));
    }

}

