using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlow_Appium_FenMora.Steps;

[Binding]
public sealed class SearchStepDefinition
{
    private readonly ScenarioContext _scenarioContext;

    public SearchStepDefinition(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }
    
    [Given(@"I navigate to Google")]
    public void GivenINavigateToGoogle()
    {
        // ScenarioContext.StepIsPending();
    }

    [When(@"I search for ""(.*)""")]
    public void WhenISearchFor(string appium)
    {
        // ScenarioContext.StepIsPending();
    }

    [Then(@"I click on the first result")]
    public void ThenIClickOnTheFirstResult()
    {
        // ScenarioContext.StepIsPending();
    }
}