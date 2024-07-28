# SpecFlow Appium Project

This project demonstrates the use of SpecFlow, Appium, and C# to automate Google search on an Android device, using the Page Object Model (POM) pattern for better maintainability and readability.
made by : Fender Mora

## Project Structure
```bash
SpecFlow_Appium_FenMora
├── Drivers
│   ├── AppiumDriver.cs
├── Features
│   ├── GoogleSearch.feature
├── Hooks
│   ├── InitializedHook.cs
├── Pages
│   ├── GoogleHomePage.cs
│   ├── GoogleResultsPage.cs
├── Steps
│   ├── SearchStepDefinition.cs
├── SpecFlow_Appium_FenMora.sln
└── README.md
```

## Setup

### Prerequisites

- JetBrains Rider (or Visual Studio)
- .NET Core SDK
- Appium Server
- Android Emulator or Real Device with Chrome installed

### NuGet Packages

Install the following NuGet packages:

- SpecFlow.NUnit
- SpecFlow.Tools.MsBuild.Generation
- Appium.WebDriver
- Selenium.WebDriver
- Selenium.Support

### Configuration

Ensure the Appium server is running locally. You can start it from the Appium desktop application or via the command line:

```sh
appium
