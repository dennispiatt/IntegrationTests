using BoDi;
using Coypu;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Zukini.UI.Steps;

public class SchedulePartialPage
{
    private BrowserSession _browser;
    private ElementScope _fieldset;

    public SchedulePartialPage(BrowserSession Browser)
    {
        _browser = Browser;
        _fieldset = _browser.FindFieldset("Schedule");
    }

    public void RunAtNextCycle() { _fieldset.FindCss("input[ng-model='ctrl.schedule.RunNow']").Check(); }
    public ElementScope ScheduleType { get { return _fieldset.FindField("scheduleType"); } }
    public ElementScope StartDate { get { return _fieldset.FindCss("input[ng-model='ctrl.schedule.StartDate']"); } }
    public ElementScope StartTimeHour { get { return _fieldset.FindField("hour"); } }
    public ElementScope StartTimeMinute { get { return _fieldset.FindField("minute"); } }
    public ElementScope StartTimeAMPM { get { return _fieldset.FindField("amPm"); } }

}


