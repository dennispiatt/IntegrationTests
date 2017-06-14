using Coypu;
using Zukini.UI.Pages;
using System.Linq;

public class DistrictPage : BasePage
{
    private const string pageTitle = "Manage District - Operations Cockpit";
    public DistrictPage(BrowserSession browser)
        : base(browser)
    {
    }

    public void AssertCurrentPage()
    {
        base.AssertCurrentPage("Manage District", Browser.Title == pageTitle);
    }

    public void AssertCurrentPage(string DistrictName)
    {
        base.AssertCurrentPage("Manage District", Browser.Title == pageTitle && Browser.HasContent("Manage District: " + DistrictName));
    }

    public ElementScope MenuBar()
    {
        return Browser.FindCss("body > div.body-content > div.container > div.btn-group");
    }

    public ElementScope MenuButton(string ButtonDisplayText)
    {
        return MenuBar().FindCss("button", text: ButtonDisplayText);
    }

    public ElementScope MenuButtonOption(string ButtonDisplayText, string OptionDisplayText)
    {
        return MenuButton(ButtonDisplayText).FindXPath("..").FindCss("a", text: OptionDisplayText);
    }

    public ElementScope IntegrationSection(string DisplayText)
    {
        return Browser.FindCss("body > div.body-content > div.container > form > div.columns").FindCss("h4", text: DisplayText).FindXPath("..");
    }

    public ElementScope IntegrationLink(string DisplayText, string SectionDisplayText)
    {
        return IntegrationSection(SectionDisplayText).FindCss("a", text: DisplayText);
    }

}

