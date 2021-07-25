Feature: Compare car insurance
    In order compare car insurances
    As a consumer 
    I should be able to provide my car details to get the insurance comparison

Scenario: Mandatory verification for Model field
    Given I lanuched compare-car-insurance page
    When I select 'Honda' for 'Make' dropdown
    And I click agree and continue
    Then I expect 'Please select an option' error message for 'Model' dropdown

Scenario: Mandatory verification for Year field
    Given I lanuched compare-car-insurance page
    When I select 'Honda' for 'Make' dropdown
    And  I select 'Accord' for 'Model' dropdown
    And I click agree and continue
    Then I expect 'Please select an option' error message for 'Year' dropdown

Scenario: Mandatory verification for Car type field
    Given I lanuched compare-car-insurance page
    When I select 'Honda' for 'Make' dropdown
    And  I select 'Accord' for 'Model' dropdown
    And  I select '2017' for 'Year' dropdown
    And I click agree and continue
    Then I expect 'Please select an option' error message for 'Car Type' dropdown

Scenario: Mandatory verification for Car type field
    Given I lanuched compare-car-insurance page
    When I select 'Honda' for 'Make' dropdown
    And  I select 'Accord' for 'Model' dropdown
    And  I select '2017' for 'Year' dropdown
    And I click agree and continue
    Then I expect 'Please select an option' error message for 'Car Type' dropdown

Scenario: Mandatory verification for Colour field
    Given I lanuched compare-car-insurance page
    When I select 'Honda' for 'Make' dropdown
    And  I select 'Accord' for 'Model' dropdown
    And  I select '2017' for 'Year' dropdown
    And  I select '9th Gen MY16 VTi Sedan 4dr Spts Auto 5sp 2.4i' for 'Car type' dropdown
    And I click agree and continue
    Then I expect 'Please select an option' error message for 'Colour' dropdown

Scenario: Mandatory verification for level of cover looking field
    Given I lanuched compare-car-insurance page
    When I select 'Honda' for 'Make' dropdown
    And  I select 'Accord' for 'Model' dropdown
    And  I select '2017' for 'Year' dropdown
    And  I select '9th Gen MY16 VTi Sedan 4dr Spts Auto 5sp 2.4i' for 'Car type' dropdown
    And  I select 'Blue' for 'Color' dropdown
    And I click agree and continue
    Then I expect 'Please select an option' error message for Insurance Cover option

Scenario: Mandatory verification for reason for cover field
    Given I lanuched compare-car-insurance page
    When I select 'Honda' for 'Make' dropdown
    And I select 'Accord' for 'Model' dropdown
    And I select '2017' for 'Year' dropdown
    And I select '9th Gen MY16 VTi Sedan 4dr Spts Auto 5sp 2.4i' for 'Car type' dropdown
    And I select 'Blue' for 'Color' dropdown
    And I select 'Comprehensive' for Insurance Cover option
    And I click agree and continue
    Then I expect 'Please select an option' error message for "Reason for cover" dropdown

Scenario: Mandatory verification for anti theft devices field
    Given I lanuched compare-car-insurance page
    When I select 'Honda' for 'Make' dropdown
    And I select 'Accord' for 'Model' dropdown
    And I select '2017' for 'Year' dropdown
    And I select '9th Gen MY16 VTi Sedan 4dr Spts Auto 5sp 2.4i' for 'Car type' dropdown
    And I select 'Blue' for 'Color' dropdown
    And I select 'Comprehensive' for Insurance Cover option
    And I select 'I have bought a new car' for 'Reason for cover' dropdown
    And I click agree and continue
    Then I expect 'Please select an option' error message for "Anti theft devices" dropdown

Scenario: Mandatory verification for factory fitted options field
    Given I lanuched compare-car-insurance page
    When I select 'Honda' for 'Make' dropdown
    And I select 'Accord' for 'Model' dropdown
    And I select '2017' for 'Year' dropdown
    And I select '9th Gen MY16 VTi Sedan 4dr Spts Auto 5sp 2.4i' for 'Car type' dropdown
    And I select 'Blue' for 'Color' dropdown
    And I select 'Comprehensive' for Insurance Cover option
    And I select 'I have bought a new car' for 'Reason for cover' dropdown
    And I select 'None' for 'Anti theft devices' dropdown
    And I click agree and continue
    Then I expect 'Please select an option' error message for "Factory fitted options" option

Scenario: Mandatory verification for non standard accessories field
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
    And I click agree and continue
    Then I expect 'Please select an option' error message for "Non standard accessories" option

Scenario: Mandatory verification for accident or hail damage field
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
    And I opted "No" for "Non standard accessories" option
    And I click agree and continue
    Then I expect 'Please select an option' error message for "Accident or damage" option

Scenario: Mandatory verification for accident or hail damage field
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
    And I click agree and continue
    Then I expect 'Please select an option' error message for "Is vehicle currently insured" dropdown
