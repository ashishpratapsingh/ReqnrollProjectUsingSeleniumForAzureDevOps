Feature: Google

This feature holds the scenarios related to https://www.google.com

@google @search
Scenario: Search a string
	Given I am on google home page
	When I enter a search string and enter
	Then google must display the search result
