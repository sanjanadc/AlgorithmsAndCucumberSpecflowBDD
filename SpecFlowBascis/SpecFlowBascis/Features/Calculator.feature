@mytag
Feature: CalculatorFeature
In order to test my application
As a developer
I want to validate different operations of the application
 
Scenario: Add two numbers
Given I have provided 70 and 20 as the inputs
When I press add
Then the result should be addition  90
 
Scenario: Substract two numbers
Given I have provided 70 and 20 as the inputs for subtraction
When I press substract
Then the result should be subtract 50
 
Scenario: Multiply two numbers
Given I have provided 70 and 20 as the inputs
When I press multiply
Then the result should be multiply 1400
 
Scenario: Divide two numbers
Given I have provided 70 and 20 as the inputs for division
When I press divide
Then the result should be divide 3.5
 
Scenario: SquareRoot of number
Given I have provided 4 as input for square root
When I press squareroot
Then the result should be squareroot 2