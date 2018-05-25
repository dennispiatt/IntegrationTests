Feature: Agreement
Display the agreement list for a district

Scenario: Sign the Agreement
	Given I am logged in as 'DistrictSuperintendent'
	And I am on the home page
	And the 'Bay-Arenac ISD' tab is expanded
	And I click on the 'Bay-Arenac ISD' link
	And I am on the 'Bay-Arenac ISD' District Page
	And I click on the 'Agreements' Menu Button
	And I click on 'Agreement List' Menu Option on the 'Agreements' Menu Button
	And I am on the 'Bay-Arenac ISD' Agreement List Page
	And I click on the View Agreement Link for 'Data Hosting Agreement'
	And I am on the 'Data Hosting Agreement' Agreement page
	When I execute Agreement Acceptance sequence
	Then I should see 'Accepted' in the results

