Feature: GoogleSearch
  Simple Search of elements in google pages

  @android
  Scenario: Search for Appium on Google Chrome Android 
    Given I navigate to Google
    When I search for "Fender"
    Then I click on the first result
