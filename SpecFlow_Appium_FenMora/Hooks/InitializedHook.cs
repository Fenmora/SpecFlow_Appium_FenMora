using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using SpecFlow_Appium_FenMora.Drivers;

namespace SpecFlow_Appium_FenMora.Hooks
{
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
            try
            {
                var appiumDriver = new AppiumDriver();
                var driver = appiumDriver.InitializeAppium();
                _scenarioContext["AppiumDriver"] = driver;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing Appium driver: {ex.Message}");
                throw;
            }
        }

        [AfterScenario]
        public void TearDown()
        {
            try
            {
                if (_scenarioContext.TryGetValue("AppiumDriver", out AndroidDriver<AppiumWebElement> driver))
                {
                    driver.Quit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during driver quit: {ex.Message}");
                throw;
            }
        }
    }
}