Feature: AmazonScenario
	

@mytag
Scenario:Amazon Account Creation
Given Iam at Amazon HomePage
And I Click Signin link, login Page is Displayed
And I Enter MobileNumber
And I click Continue Button
And I Enter Password
When I Click Login Button
Then I log into my Amazon Account

@mytag
Scenario: Add Address
Given Iam at Amazon HomePage
And I click Your orders link
And I press Your Address
And I Click Add Address link
And I Enter Adderss Details
When I Press Add Address Button
Then Address Should be Added

@mytag
Scenario: Modify Address
Given Iam at Amazon HomePage
And I click Your orders link
And I press Your Address
And I click Edit
And I modify Address Details
When I click Save Changes
Then Address is saved

@mytag
Scenario: Delete Address
Given Iam at Amazon HomePage
And I click Your orders link
And I press Your Address
And I click Delete 
When I press yes Button
Then Address is Deleted

@mytag
Scenario: Search for Product
Given Iam at Amazon HomePage
And I enter Product name in Search box
And i click on Search Symbol
And I click On the product
And I click Add to cart
When I click Proceed to buy
Then Page Navigates to Payment Options

@mytag
Scenario: Logout,Login Back to Website
Given Iam at Amazon HomePage
And I place cursor on Your orders link
And I Click Signout link, login page is displayed
And I Enter MobileNumber
And I click Continue Button
And I Enter Password
When I Click Login Button
Then I log into my Amazon Account

@mytag
Scenario:Search for Sports shoes
Given Iam at Amazon HomePage
And I Search Shoes name in Search box
And I press enter
And I click on Shoes
And I Select the size
When I click BuyNow option
Then It Navigates to Payment page








