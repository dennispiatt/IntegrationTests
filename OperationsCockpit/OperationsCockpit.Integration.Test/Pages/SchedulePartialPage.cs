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

    public void RunAtNextCycle() { _fieldset.Check("RunNow"); }
}

