Feature: InboundIntegration
	Manage Inbound INtegrations

Scenario: Set the Integration to Run At Next Cycle
	Given I am logged in as 'district1TechContact1'
	And I navigate to integration 'Student Information System: CIMS 1' for district 'Bay-Arenac ISD' in ISD 'Bay-Arenac ISD' Inbound Integration Page
	And I Select Run At Next Cycle
	When I Submit the form
	Then I should be on the District page for 'Bay-Arenac ISD'