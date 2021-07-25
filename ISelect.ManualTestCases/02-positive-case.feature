Feature: Compare car insurance
    In order compare car insurances
    As a consumer 
    I should be able to provide my car details to get the insurance comparison

Scenario: Verify I am able to submit 'About your car' page
    Given I lanuched compare-car-insurance page
    When I select 'Honda' for 'Make' dropdown
    And I select 'Accord' for 'Model' dropdown
    And I select '2017' for 'Year' dropdown
    And I select '9th Gen MY16 VTi Sedan 4dr Spts Auto 5sp 2.4i' for 'Car type' dropdown
    And I select 'Blue' for 'Color' dropdown
    And I select 'Comprehensive' for Insurance Cover option
    And I select 'I have bought a new car' for 'Reason for cover' dropdown
    And I select 'None' for 'Anti theft devices' dropdown
    And I opted "No" for "Factory fitted options" option
    And I opted "No" for "Accident or damage" option
    And I select 'No, I am just buying the car' for 'Is vehicle currently insured' dropdown
    And I click agree and continue
    Then I expect I am navigated to 'Usage & Driver' page