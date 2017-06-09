Feature: AgreementList
Display the agreement list for a district

@ignore 
Scenario: Go To Agreement Page
	Given I am logged in as 'DistrictSuperintendent'
	And I am on the home page
	And the 'Bay-Arenac ISD' tab is expanded
	And I click on the 'Bay-Arenac ISD' link
	And I am on the 'Bay-Arenac ISD' District Page
	And I click on the 'Agreements' Menu Button
	And I click on 'Agreement List' Menu Option on the 'Agreements' Menu Button
	And I am on the 'Bay-Arenac ISD' Agreement List Page
	When I click on the View Agreement Link for 'Data Hosting Agreement - GMEC'
	Then I should be on the Agreement page for 'Data Hosting Agreement - GMEC'
