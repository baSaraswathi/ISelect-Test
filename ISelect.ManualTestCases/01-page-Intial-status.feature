Feature: Compare car insurance
    In order compare car insurances
    As a consumer 
    I should be able to provide my car details to get the insurance comparison

Scenario: Verification of intial page status
    Given I lanuched compare-car-insurance page
    When I visit the page
    Then I expect following fields should be enabled 
    |Enabled_Fields             |
    |Make                       |
    |LevelOfCover               |
    |ReasonForLookingCover      |
    |AntiTheftDevices           |
    |NonStandardAccessories     |
    |AccidentOrDamage           |
    |IsVehicleCurrentlyInsured  |
    |AcceptTermsAndConditions   |
    Then I expect following fields should be disabled
    |Disabled_Fields  |
    |Model          |
    |Year           |
    |CarTypeOrSeries|
    |Transmission   |
    |FuelType       |
    |Color          |
