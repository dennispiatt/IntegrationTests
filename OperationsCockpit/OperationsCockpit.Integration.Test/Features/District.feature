Feature: District
Display and Manage district details
 
Scenario: Go To Agreement List Page
	Given I am logged in as 'DistrictSuperintendent'
	And I navigate to district 'Bay-Arenac ISD' in ISD 'Bay-Arenac ISD' District Page
	And I click on the 'Agreements' Menu Button
	When I click on 'Agreement List' Menu Option on the 'Agreements' Menu Button
	Then I should be on the Agreement List page for 'Bay-Arenac ISD'

Scenario: Go To Add Inbound Integration Page
	Given I am logged in as 'district1TechContact1'
	And I navigate to district 'Bay-Arenac ISD' in ISD 'Bay-Arenac ISD' District Page
	And There is not an item named 'Student Information System: CIMS 1' in the 'Inbound Integration' section
	When I click on the 'Add Integration' link in the 'Inbound Integration' section
	Then I should be on the Inbound Integration page for 'Add Inbound Integration'

Scenario: Go To Manage Inbound Integration Page
	Given I am logged in as 'district1TechContact1'
	And I navigate to district 'Bay-Arenac ISD' in ISD 'Bay-Arenac ISD' District Page
	And There is an item named 'Student Information System: CIMS 1' in the 'Inbound Integration' section
	When I click on the 'Student Information System: CIMS 1' link in the 'Inbound Integration' section
	Then I should be on the Inbound Integration page for 'Student Information System: CIMS 1'