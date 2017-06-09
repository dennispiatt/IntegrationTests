using Coypu;
using Zukini.UI.Pages;

public class AgreementListPage : BasePage
{
    private const string pageTitle = "Agreement List - Operations Cockpit";
    public AgreementListPage(BrowserSession browser)
        : base(browser)
    {
    }

    public ElementScope AgreementLink(string AgreementName)
    {
        var agreementTable = Browser.FindCss("body > div.container.body-content > div.container > table");
        var agreementCell = Browser.FindCss("td", text: AgreementName);
        return agreementCell.FindXPath("..").FindCss("a", text: "View Agreement");
    }

    public void AssertCurrentPage ()
    {
        base.AssertCurrentPage("Agreement List", Browser.Title == pageTitle);
    }

    public void AssertCurrentPage(string DistrictName)
    {
        base.AssertCurrentPage("Agreement List", Browser.Title == pageTitle && Browser.HasContent(DistrictName));
    }

}
