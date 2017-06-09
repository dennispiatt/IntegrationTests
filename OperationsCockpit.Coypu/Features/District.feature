Feature: District
Display and Manage district details

@ignore 
Scenario: Go To Agreement List Page
	Given I am logged in as 'DistrictSuperintendent'
	And I am on the home page
	And the 'Bay-Arenac ISD' tab is expanded
	And I click on the 'Bay-Arenac ISD' link
	And I am on the 'Bay-Arenac ISD' District Page
	And I click on the 'Agreements' Menu Button
	When I click on 'Agreement List' Menu Option on the 'Agreements' Menu Button
	Then I should be on the Agreement List page for 'Bay-Arenac ISD'

Scenario: Go To Add Inbound Integration Page
	Given I am logged in as 'RegionAdmin'
	And I am on the home page
	And the 'Bay-Arenac ISD' tab is expanded
	And I click on the 'Bay-Arenac ISD' link
	And I am on the 'Bay-Arenac ISD' District Page
	And There is not already an item named 'Student Information System: CIMS 1' in the 'Inbound Integration' section
	When I click on the 'Add Integration' link in the 'Inbound Integration' section
	Then I should be on the Inbound Integration page for 'Add Inbound Integration'

Scenario: Go To Manage Inbound Integration Page
	Given I am logged in as 'RegionAdmin'
	And I am on the home page
	And the 'Bay-Arenac ISD' tab is expanded
	And I click on the 'Bay-Arenac ISD' link
	And I am on the 'Bay-Arenac ISD' District Page
	When I click on the 'Student Information System: CIMS 1' link in the 'Inbound Integration' section
	Then I should be on the Inbound Integration page for 'Student Information System: CIMS 1'