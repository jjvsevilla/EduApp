﻿Feature: SmokeTest
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@smoke
Scenario: the user login the system
	Given that the user is at login page
		And the user inserts "a@a.com" as email
		And the user inserts "123456" as password
	When the user clicks the login button 
	Then the system redirects to the home page

Scenario: the user goes to exam page
	Given that the user is at login page
		And the user inserts "a@a.com" as email
		And the user inserts "123456" as password
	When the user clicks the login button 
	Then the system redirects to the home page
	When the user clicks the Exam link
	Then the system redirects to the exam page
	When the user clicks on create new 
	#Then the system redirects to the new exam page

