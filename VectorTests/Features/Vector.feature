Feature: Feature for Vector Demo Tests


Scenario: Create an account
	Given I navigate to the application page
	And I navigate to the Sign Up page
	And I use "Pietro" as Fist Name
	And I use "Braga" as Last Name
	And I use an aleatory email
	And I use a strong password
	When I submit the Signup Form
	Then a green check icon should be displayed
	And a the Welcome Message should contains "Pietro"
	And a Log Out button exists


Scenario: Login into application
	Given I navigate to the application page
	And I navigate to the Login Page
	And I use "vectortest@mailinator.com" as login email
	And I use "V3ectoT3st" as login password
	When I click on Log In Button
	Then a the Welcome Message should contains "Vector"
	And a Log Out button exists

Scenario: Search anything
	Given I navigate to the application page
	When I search for "soccer"
	Then the search page is displayed

Scenario: Follow a favorite sport
	Given I navigate to the application page
	And I navigate to the Sign Up page
	And I use "Pietro" as Fist Name
	And I use "Braga" as Last Name
	And I use an aleatory email
	And I use a strong password
	When I submit the Signup Form
	Then a green check icon should be displayed
	And a the Welcome Message should contains "Pietro"
	And a Log Out button exists
	Given I open My Favorites Panel
	When I click to follow any Suggested Sport
	Then My Sports List is not empty and should contails a Unfollow button