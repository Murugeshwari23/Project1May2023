﻿Feature: TMFeature

In TurnUp Portal we can create, edit, and delete time and materials records and can manage 
employees time and materials data successfully.


Scenario: create time and material record with valid details
	Given Logged into turnup portal successfully
	When  navigate to time and material page 
	And create a new time and material record
	Then The record should be created successfully

Scenario Outline: Edit existing time and material record with valid details
   Given Logged into turnup portal successfully
	When  navigate to time and material page 
	And edit '<Code>' on an existing time and material record
	Then The record should be edited '<Code>' successfully

Examples:
| Code           |
| 100            |
| Second Project |
| Third Project  |
| Fourth Project |


		