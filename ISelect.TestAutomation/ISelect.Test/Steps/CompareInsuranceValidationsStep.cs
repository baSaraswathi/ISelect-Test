using ISelect.Automation.Web.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit;

namespace ISelect.Test.Steps
{
    [Binding]
    public class CompareInsuranceValidationsStep : ISelectBaseSteps
    {
        public CompareInsuranceValidationsStep(FeatureContext context) : base(context)
        { }

        [Given(@"I lanuched compare-car-insurance page")]
        public void GivenILanuchedCompare_Car_InsurancePage()
        {
            AppDriver.Navigate().GoToUrl("https://car.iselect.com.au/car/compare-car-insurance/gatewayStore");
            AppDriver.Manage().Window.Maximize();
        }

        [When(@"I select (.*) for (.*) dropdown")]
        public void SelectValueInDropdown(string value, string fieldName)
        {
            var page = new AboutYourCarPage(AppDriver);
            switch (fieldName)
            {
                case "Make":
                    page.SetMakeDropdownValue(value);
                    break;
                case "Model":
                    page.SetModelDropdownValue(value);
                    break;
                case "Year":
                    page.SetYearDropdownValue(value);
                    break;
                case "Car type":
                    page.SetCarTypeDropdownValue(value);
                    break;
                case "Colour":
                    page.SetColorDropdownValue(value);
                    break;
                case "Cover reason":
                    page.SetReasonForCoverDropdownValue(value);
                    break;
                case "Anti theft devices":
                    page.SetAntiTheftDevicesDropdownValue(value);
                    break;
                case "Vehicle currently insurred":
                    page.SetIsVehicleCurrentlyInsurred(value);
                    break;
                default:
                    throw new InvalidOperationException($"Unable perform action for field: {fieldName}");
            }
        }

        [When(@"I click agree and continue")]
        public void ClickAgreeAndContinue()
        {
            var page = new AboutYourCarPage(AppDriver);
            page.CheckAgreeCheckBox();
            page.ClickContinueButton();
            Thread.Sleep(3000);
        }

        [When(@"I opted (.*) for (.*) option")]
        public void SelectOption(string value, string fieldName)
        {
            var page = new AboutYourCarPage(AppDriver);
            switch (fieldName)
            {
                case "Factory fitted options":
                    page.SetFactoryFittedOptionsOption(value);
                    break;
                case "Non standard accessories":
                    page.SetNonStandardAccessoriesOption(value);
                    break;
                case "Accident Or Hail Damage":
                    page.SetAccidentOrHailDamageOption(value);
                    break;
                default:
                    throw new InvalidOperationException($"Unable perform action for field: {fieldName}");
            }
        }

        [When(@"I select (.*) for Insurance Cover option")]
        public void SelectCover(string value)
        {
            var page = new AboutYourCarPage(AppDriver);
            page.SetCover(value);
        }

        [Then(@"I expect (.*) error message for (.*) dropdown")]
        public void CheckErrorMessageForDropdown(string message, string fieldName)
        {
            var page = new AboutYourCarPage(AppDriver);
            switch (fieldName)
            {
                case "Model":
                    Assert.True(page.IsModelDropdownHasError(message));
                    break;
                case "Year":
                    Assert.True(page.IsYearDropdownHasError(message));
                    break;
                case "Car type":
                    Assert.True(page.IsCarTypeDropdownHasError(message));
                    break;
                case "Colour":
                    Assert.True(page.IsColorDropdownHasError(message));
                    break;
                case "Cover reason":
                    Assert.True(page.IsCoverReasonDropdownHasError(message));
                    break;
                case "Anti theft devices":
                    Assert.True(page.IsAntiTheftDevicesDropdownHasError(message));
                    break;

                default:
                    throw new InvalidOperationException($"Unable perform action for field: {fieldName}");
            }
        }

        [Then(@"I expect (.*) error message for Insurance Cover option")]
        public void CheckErrorMessageForInsuranceCover(string message)
        {
            var page = new AboutYourCarPage(AppDriver);
            page.IsCoverHasError(message);
        }
    }
}
