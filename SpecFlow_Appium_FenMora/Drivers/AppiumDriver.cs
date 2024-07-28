using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Support.UI;

namespace SpecFlow_Appium_FenMora.Drivers
{
    public class AppiumDriver
    {
        public AppiumDriver<AppiumWebElement> Driver { get; set; }

        public AndroidDriver<AppiumWebElement> InitializeAppium()
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "PixelSpecFlow");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "11");
            driverOptions.AddAdditionalCapability("appPackage", "com.android.chrome");
            driverOptions.AddAdditionalCapability("appActivity", "com.google.android.apps.chrome.Main");
            driverOptions.AddAdditionalCapability("autoGrantPermissions", "true");
            driverOptions.AddAdditionalCapability("noReset", "true");

            return new AndroidDriver<AppiumWebElement>(new Uri("http://0.0.0.0:4723/wd/hub"), driverOptions);
        }

        public void WaitForAppToLoad(AndroidDriver<AppiumWebElement> driver, int timeoutInSeconds)
        {
            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error waiting for app to load: {ex.Message}");
                throw;
            }
        }
    }
}