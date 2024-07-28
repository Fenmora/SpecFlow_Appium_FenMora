using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using OpenQA.Selenium.Appium;

namespace SpecFlow_Appium_FenMora.Pages
{
    public class GoogleResultsPage
    {
        private readonly AndroidDriver<AppiumWebElement> _driver;
        private readonly By _firstResult = By.XPath("//android.view.View[@content-desc=\"Fender https://www.fender.com › start Fender\"]");

        public GoogleResultsPage(AndroidDriver<AppiumWebElement> driver)
        {
            _driver = driver;
        }

        public void ClickOnFirstResult()
        {
            var firstResult = _driver.FindElement(_firstResult);
            Thread.Sleep(1000);
            firstResult.Click();
            firstResult.Click();
            Thread.Sleep(10000);
        }
    }
}