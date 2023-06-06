Feature: TMFeature

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
	And edit '<Code>', '<Description>' and '<Price>' on an existing time and material record
	Then The record should be edited '<Code>', '<Description>' and '<Price>' successfully

Examples:
| Code           | Description | Price |
| First Project  | ammu        | 100   |
| Second Project | susee       | 200   |
| Third Project  | shyam       | 300   |
| Fourth Project | baby        | 400   |

		