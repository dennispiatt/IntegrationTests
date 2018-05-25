Feature: Login
  In order to access my account
  As a user of the website
  I want to log into the website

Scenario Outline: Login As User  
Given I am at the login page
When I enter the <user> username and password
And I click the login button
Then I should see <display> in the results
Examples:
| user                            | display                                                  |
| TestUser                        | Hello testuser@operationscockpit.com!                    |
| JaneDoe                         | Hello jane.doe@test.com!                                 |
| district1TechContact1           | Hello district1TechContact1@test.com!                    |
| district1TechContact2           | Hello district1TechContact2@test.com!                    |
| TestOperationsManager           | Hello operationsmanager@operationscockpit.com!           |
| TestDataHubDataCustodian        | Hello datahubdatacustodian@operationscockpit.com!        |
| TestDataHubSuperintendent       | Hello datahubsuperintendent@operationscockpit.com!       |
| TestDatahubSuperintendentProxy  | Hello datahubsuperintendentproxy@operationscockpit.com!  |
| DistrictSuperintendent          | Hello districtsuperintendent@operationscockpit.com!      |
| TestDistrictSuperintendentProxy | Hello districtsuperintendentproxy@operationscockpit.com! |
| RegionAdmin                     | Hello regionadmin@operationscockpit.com!                 |




