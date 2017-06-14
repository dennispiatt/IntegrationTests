using Coypu;
using Zukini.UI.Pages;
using System.Linq;

public class InboundIntegrationPage : BasePage
{
    private const string pageTitle = "Manage Integration - Operations Cockpit";
    public InboundIntegrationPage(BrowserSession browser)
        : base(browser)
    {
    }

    public void AssertCurrentPage()
    {
        base.AssertCurrentPage("Manage Integration", Browser.Title == pageTitle);
    }

    public void AssertCurrentPage(string DisplayText)
    {
        base.AssertCurrentPage("Manage Integration", Browser.Title == pageTitle && Browser.HasContent(DisplayText));
    }

    public SchedulePartialPage Schedule {
        get
        {
            return new SchedulePartialPage(Browser);
        }
    }

    public void Submit() { Browser.ClickButton("Submit"); }    


}

