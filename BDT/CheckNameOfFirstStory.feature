Feature: check name of first story

@mytag

Scenario: check name of first story
Given Opened News tab
When Got text from the first story on the page
Then Text should be equal to expected text

