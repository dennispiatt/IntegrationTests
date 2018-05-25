Feature: InboundIntegration
	Manage Inbound Integrations

Scenario: Add an Inbound Integration
	Given I am logged in as 'district1TechContact1'
	And I navigate to district 'Bay-Arenac ISD' in ISD 'Bay-Arenac ISD' District Page
	And There is not an item named 'Student Information System: CIMS 1' in the 'Inbound Integration' section
	And I click on the 'Add Integration' link in the 'Inbound Integration' section
	And Add an Integration for 'Student Information System','Wiedenhammer','CIMS - v1','Current Year','Local','<UseDefault>','1Password!','One-Time','05/01/2018','1','00','AM',''
	When I Submit the form
	Then I should be on the District page for 'Bay-Arenac ISD'  

Scenario: Set the Integration to Run At Next Cycle
	Given I am logged in as 'district1TechContact1'
	And I navigate to integration 'Student Information System: CIMS 1' for district 'Bay-Arenac ISD' in ISD 'Bay-Arenac ISD' Inbound Integration Page
	And I Select Run At Next Cycle
	When I Submit the form
	Then I should be on the District page for 'Bay-Arenac ISD'  