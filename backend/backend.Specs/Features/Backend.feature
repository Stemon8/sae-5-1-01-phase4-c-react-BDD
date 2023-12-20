Feature: Backend
	Simple feature to test the back

@mytag
Scenario: Add a challenge and verify it is added in a false completion state
	Given a challenge named "Challenge"
	And a description with contents "contents"
	And a team Guid of "teamGuid"
	And a target Guid of "targetGuid"
	When when I add the challenge
	Then the challenge should be added
	And the challenge should have a completion state of false