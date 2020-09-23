Feature: check name of first story

@mytag

Scenario: check name of first story
Given Entered BBC home page
And Clicked on News tab
And Closed pop-up window
When Got text from the first story on the page
Then Text should be equal to expected text

#Feature:Google  Key word search
#
#@mytag
#
#Scenario: search Spec Flow in Google search bar
#Given I have entered the Google Home page
#And I have entered spec flow into google search bar
#When I press search button
#Then the result should be a new pages with results for spec flow