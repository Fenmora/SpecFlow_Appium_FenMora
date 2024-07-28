using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using OpenQA.Selenium.Appium;

namespace SpecFlow_Appium_FenMora.Pages
{
    public class GoogleHomePage
    {
        private readonly AndroidDriver<AppiumWebElement> _driver;
        private readonly By _searchBox = By.XPath("//android.webkit.WebView//android.widget.EditText");

        public GoogleHomePage(AndroidDriver<AppiumWebElement> driver)
        {
            _driver = driver;
        }

        public void NavigateToGoogle()
        {
            _driver.Navigate().GoToUrl("https://www.google.com");
            Thread.Sleep(5000);  // Delay for observation
        }

        public void SearchFor(string searchQuery)
        {
            var searchBox = _driver.FindElement(_searchBox);
            searchBox.Click();
            Thread.Sleep(1000);  // Delay for observation
            searchBox.SendKeys(searchQuery);
            Thread.Sleep(1000);  // Delay for observation
            _driver.PressKeyCode(AndroidKeyCode.Keycode_ENTER);
            Thread.Sleep(5000);  // Delay for observation
        }
    }
}