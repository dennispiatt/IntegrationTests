Feature: DistrictList
Display the district list expand and contract
 
Scenario: Expand an ISD Tab
	Given I am logged in as 'RegionAdmin'
	And I am on the home page
	And the 'Bay-Arenac ISD' tab is not expanded
	When I click on the 'Bay-Arenac ISD' tab
	Then I should see the 'Bay-Arenac ISD' link
	 
Scenario: Select A District
	Given I am logged in as 'RegionAdmin'
	And I am on the home page
	And the 'Bay-Arenac ISD' tab is expanded  
	When I click on the 'Bay-Arenac ISD' link
	Then I should be on the District page for 'Bay-Arenac ISD'