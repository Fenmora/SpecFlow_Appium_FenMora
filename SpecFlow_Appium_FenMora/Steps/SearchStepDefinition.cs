using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using SpecFlow_Appium_FenMora.Pages;
using TechTalk.SpecFlow;

namespace SpecFlow_Appium_FenMora.Steps
{
    [Binding]
    public sealed class SearchStepDefinition
    {
        private readonly AndroidDriver<AppiumWebElement> _driver;
        private readonly GoogleHomePage _googleHomePage;
        private readonly GoogleResultsPage _googleResultsPage;

        public SearchStepDefinition(ScenarioContext scenarioContext)
        {
            _driver = scenarioContext["AppiumDriver"] as AndroidDriver<AppiumWebElement>;
            _googleHomePage = new GoogleHomePage(_driver);
            _googleResultsPage = new GoogleResultsPage(_driver);
        }

        [Given(@"I navigate to Google")]
        public void GivenINavigateToGoogle()
        {
            try
            {
                _googleHomePage.NavigateToGoogle();
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
                _googleHomePage.SearchFor(searchQuery);
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
                _googleResultsPage.ClickOnFirstResult();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error clicking on the first result: {ex.Message}");
                throw;
            }
        }
    }
}