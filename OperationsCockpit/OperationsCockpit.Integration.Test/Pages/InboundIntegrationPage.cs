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

    public SourcePartialPage Source
    {
        get
        {
            return new SourcePartialPage(Browser);
        }
    }

    public ElementScope SystemType { get { return Browser.FindField("systemType"); } }
    public ElementScope Vendor { get { return Browser.FindField("vendor"); } }
    public ElementScope System { get { return Browser.FindField("system"); } }
    public ElementScope Year { get { return Browser.FindCss("select[ng-model='ctrl.integration.SchoolYear']"); } }
    public ElementScope NotificationEmail { get { return Browser.FindField("emails"); } }

    public void Submit() {
        ElementScope submit = Browser.FindCss("a[ng-click='ctrl.submit(ctrl.model)']");
        submit.Click();
        bool SpinnyMissing = submit.FindCss("span.btn-spinner").Missing();
    }
}