using BoDi;
using Coypu;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Zukini.UI.Steps;

public class SourcePartialPage
{
    private BrowserSession _browser;
    private ElementScope _fieldset;
        
    public SourcePartialPage(BrowserSession Browser)
    {
        _browser = Browser;
        _fieldset = _browser.FindFieldset("Source");
    }

    public ElementScope LocationTypeLocal { get { return _fieldset.FindCss("input[ng-model='ctrl.source.LocationType'][value='0']"); } }
    public ElementScope LocationTypeRemote { get { return _fieldset.FindCss("input[ng-model='ctrl.source.LocationType'][value='1']"); } }
    public ElementScope UserId { get { return _fieldset.FindField("userId"); } }
    public ElementScope UserPassword { get { return _fieldset.FindField("userPassword"); } }
}

