Feature: Bank Feature
	In order to use ATM
	As a Bank account holder
	I want to be asked for PIN to Withdraw money

@regression
Scenario:  ATM - Enter Pin and withdrawal money
	Given I have $1000 in my account
	And I entered PIN as 4141
	When I withdraw $200 from ATM
	Then My balance should be $800

@sanity
Scenario: ATM - Enter Pin
	When I enter PIN as 4141
	Then I should see the Transaction options

