Feature: Login
	In order to access my account
    As a user of the website
    I want to log into the website

Scenario: Successful Login with Valid Credentials
	 
	Given User have navigated to Login page
	When  User enters valid username and password & clicks login
	Then Successful LogIN message should display


Scenario: Unsuccessful Login with Invalid Credentials
	 
	Given User have navigated to Login page
	When  User enters invalid username and password & clicks login
	Then UnSuccessful LogIN message should display
