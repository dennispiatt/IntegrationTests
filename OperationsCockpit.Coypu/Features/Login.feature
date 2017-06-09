Feature: Login
  In order to access my account
  As a user of the website
  I want to log into the website

Scenario: Login Region Admin
Given I am at the login page
When I enter the 'RegionAdmin' username and password
And I click the login button
Then I should see 'Hello regionadmin@operationscockpit.com!' in the results

@ignore 
Scenario: Login District Superintendent
Given I am at the login page
When I enter the 'DistrictSuperintendent' username and password
And I click the login button
Then I should see 'Hello districtsuperintendent@operationscockpit.com!' in the results


