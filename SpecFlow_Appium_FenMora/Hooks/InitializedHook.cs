using SpecFlow_Appium_FenMora.Drivers;

namespace SpecFlow_Appium_FenMora.Hooks;
[Binding]
class InitializedHook
{
    private readonly ScenarioContext _scenarioContext;

    public InitializedHook(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }
    
    [BeforeScenario]
    public void Initialized()
    {
        AppiumDriver appiumDriver = new AppiumDriver();
        appiumDriver.InitializeAppium();
    }

}