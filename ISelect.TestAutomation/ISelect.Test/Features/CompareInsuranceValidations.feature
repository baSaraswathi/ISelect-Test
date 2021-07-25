Feature: Compare car insurance - Validations
    In order compare car insurances
    As a consumer 
    I should be able to provide my car details to get the insurance comparison

@CompareCarInsuranceValidation
Scenario: 01-Mandatory verification for Model field
    Given I lanuched compare-car-insurance page
    When I select Honda for Make dropdown
    And I click agree and continue
    Then I expect Please select an option error message for Model dropdown

@CompareCarInsuranceValidation
Scenario: 02-Mandatory verification for Year field
    Given I lanuched compare-car-insurance page
    When I select Honda for Make dropdown
    And I select Accord for Model dropdown
    And I click agree and continue
    Then I expect Please select an option error message for Year dropdown

@CompareCarInsuranceValidation
Scenario: 03-Mandatory verification for Car type field
    Given I lanuched compare-car-insurance page
    When I select Honda for Make dropdown
    And I select Accord for Model dropdown
    And I select 2017 for Year dropdown
    And I click agree and continue
    Then I expect Please select an option error message for Car type dropdown

@CompareCarInsuranceValidation
Scenario: 04-Mandatory verification for Colour field
    Given I lanuched compare-car-insurance page
    When I select Honda for Make dropdown
    And I select Accord for Model dropdown
    And I select 2017 for Year dropdown
    And I select 9th Gen MY16 VTi Sedan 4dr Spts Auto 5sp 2.4i for Car type dropdown
    And I click agree and continue
    Then I expect Please select an option error message for Colour dropdown

Scenario: 05-Mandatory verification for level of cover looking field
    Given I lanuched compare-car-insurance page
    When I select Honda for Make dropdown
    And I select Accord for Model dropdown
    And I select 2017 for Year dropdown
    And I select 9th Gen MY16 VTi Sedan 4dr Spts Auto 5sp 2.4i for Car type dropdown
    And  I select Blue for Colour dropdown
    And I click agree and continue
    Then I expect Please select an option error message for Insurance Cover option

Scenario: 06-Mandatory verification for reason for cover field
    Given I lanuched compare-car-insurance page
    When I select Honda for Make dropdown
    And I select Accord for Model dropdown
    And I select 2017 for Year dropdown
    And I select 9th Gen MY16 VTi Sedan 4dr Spts Auto 5sp 2.4i for Car type dropdown
    And  I select Blue for Colour dropdown
    And I select Comprehensive for Insurance Cover option
    And I click agree and continue
    Then I expect Please select an option error message for Cover reason dropdown

Scenario: 07-Mandatory verification for anti theft devices field
    Given I lanuched compare-car-insurance page
    When I select Honda for Make dropdown
    And I select Accord for Model dropdown
    And I select 2017 for Year dropdown
    And I select 9th Gen MY16 VTi Sedan 4dr Spts Auto 5sp 2.4i for Car type dropdown
    And  I select Blue for Colour dropdown
    And I select Comprehensive for Insurance Cover option
    And I select I have bought a new car for Cover reason dropdown
    And I click agree and continue
    Then I expect Please select an option error message for Anti theft devices dropdown
