using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using static OpenQA.Selenium.Support.UI.ExpectedConditions;


namespace SpecFlow_Appium_FenMora.Steps
{
    [Binding]
    public sealed class SearchStepDefinition
    {
        private readonly AndroidDriver<AppiumWebElement>? driver;

        public SearchStepDefinition(ScenarioContext scenarioContext)
        {
            driver = scenarioContext["AppiumDriver"] as AndroidDriver<AppiumWebElement>;
        }
 
        [Given(@"I navigate to Google")]
        public void GivenINavigateToGoogle()
        {
            try
            {
                driver!.Navigate().GoToUrl("https://www.google.com");
                Thread.Sleep(5000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error navigating to Google: {ex.Message}");
                throw;
            }
        }

        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string searchQuery)
        {
            try
            {
                var searchBox = driver.FindElement(By.XPath("//android.webkit.WebView//android.widget.EditText"));
                searchBox.Click();
                Thread.Sleep(1000);
                searchBox.SendKeys(searchQuery);
                Thread.Sleep(1000);
                driver.PressKeyCode(AndroidKeyCode.Keycode_ENTER);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching for {searchQuery}: {ex.Message}");
                throw;
            }
        }

        [Then(@"I click on the first result")]
        public void ThenIClickOnTheFirstResult()
        {
            try
            {
                var firstResult = driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Fender https://www.fender.com › start Fender\"]"));
                Thread.Sleep(1000);
                firstResult.Click();
                firstResult.Click();
                Thread.Sleep(10000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error clicking on the first result: {ex.Message}");
                throw;
            }
        }
    }
}
