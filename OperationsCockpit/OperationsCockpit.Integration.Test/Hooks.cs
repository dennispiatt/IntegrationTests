using System;
using Coypu;
using Coypu.Drivers;
using TechTalk.SpecFlow;
using System.IO;

[Binding]
public class Hooks
{
    private readonly SessionConfiguration _sessionConfiguration;

    public Hooks(SessionConfiguration sessionConfig)
    {
        _sessionConfiguration = sessionConfig;
    }

    [BeforeScenario]
    public void BeforeScenario()
    {
        _sessionConfiguration.AppHost = OperationsCockpit.Integration.Test.Properties.Settings.Default.AppHost;
        _sessionConfiguration.Browser = Browser.Parse(OperationsCockpit.Integration.Test.Properties.Settings.Default.Browser);
        _sessionConfiguration.Timeout = TimeSpan.FromSeconds(3);
        _sessionConfiguration.RetryInterval = TimeSpan.FromSeconds(0.1);        
    }
}
