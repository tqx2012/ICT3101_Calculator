﻿Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have a calculator
	When I have entered "5" and "20" into the calculator and press add
	Then the result should be "25"


	@Addition
Scenario Outline: Add zeros for special cases
	Given I have a calculator
	When I have entered "<value1>" and "<value2>" into the calculator and press add
	Then the result should be "<value3>"

	Examples:
		| value1 | value2 | value3 |
		| 0      | 20     | 2      |
		| 20     | 0      | 200    |
		| 0      | 0      | 666    |