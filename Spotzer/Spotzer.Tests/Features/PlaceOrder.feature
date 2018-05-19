Feature: PlaceOrder
	To check the placement of order as 
	expected for all the partners

Scenario: Place Order
	Given I create a new Order
	    | Field            | Value          |
		| Partner          | Test Project   |
		| OrderID          | 1              |
		| TypeOfOrder      | Type 1         |
		| SubmittedBy      | test           |
		| CompanyID        | 1              |
		| CompanyName      | test           |
		| ContactFirstName | test           |
		| ContactLastName  | test           |
		| ContactTitle     | test           |
		| ContactPhone     | test           |
		| ContactMobile    | test           |
		| ContactEmail     | test           |
		| ExposureID       | test           |
		| UDAC             | test           |
		| RelatedOrder     | test           |
	And The Line Item Exist
	    | Field               | Value          |
		| ID                  | 1              |
		| ProductID           | Test Product   |
		| ProductType         | Type 1         |
		| Notes               | test           |
		| Category            | 1              |
    And The WebsiteDetails Exist
	    | Field               | Value          |
		| TemplateId          | Test Project   |
		| WebsiteBusinessName | 1              |
		| WebsiteAddressLine1 | Type 1         |
		| WebsiteAddressLine2 | test           |
		| WebsiteCity         | 1              |
		| WebsiteState        | test           |
		| WebsitePostCode     | test           |
		| WebsitePhone        | test           |
		| WebsiteEmail        | test           |
		| WebsiteMobile       | test           |
	 And The AdWordCampaign Exist
	    | Field                 | Value          |
		| CampaignName          | Test Project   |
		| CampaignAddressLine1  | 1              |
		| CampaignPostCode      | Type 1         |
		| CampaignRadius        | test           |
		| LeadPhoneNumber       | 1              |
		| SMSPhoneNumber        | test           |
		| UniqueSellingPoint1   | test           |
		| UniqueSellingPoint2   | test           |
		| UniqueSellingPoint3   | test           |
		| Offer                 | test           |
		| DestinationURL        | test           |
    And ModelState is correct
	Then the system should return order success message
