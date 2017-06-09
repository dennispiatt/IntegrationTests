using Coypu;
using Zukini.UI.Pages;

public class DistrictListPage : BasePage
{
    private const string pageTitle = "District List - Operations Cockpit";
    public DistrictListPage(BrowserSession browser)
        : base(browser)
    {
    }

    public ElementScope IsdTab(string IsdName)
    {
        return Browser.FindId("accordion").FindCss("h3", text: IsdName);
    }

    public ElementScope DistrictLink(string DistrictName)
    {
        return Browser.FindCss("a", text: DistrictName);
    }

    public void AssertCurrentPage ()
    {
        base.AssertCurrentPage("District List", Browser.Title == pageTitle);
    }
}
