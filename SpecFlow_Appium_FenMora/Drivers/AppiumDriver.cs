using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
namespace SpecFlow_Appium_FenMora.Drivers;

public class AppiumDriver
{
    public AppiumDriver<AppiumWebElement> Driver { get; set; }

    public AndroidDriver<AppiumWebElement> InitializeAppium()
    {
        var driverOptions = new AppiumOptions();
        driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName,"Android");
        driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName,"emulator-5554");
        driverOptions.AddAdditionalCapability("appPackage", "com.android.chrome");
        driverOptions.AddAdditionalCapability("appActivity", "com.google.android.apps.chrome.Main");
        // driverOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2");
        
        return new AndroidDriver<AppiumWebElement>(new Uri("http://0.0.0.0:4723/wd/hub"),driverOptions) ;
    }
    
}