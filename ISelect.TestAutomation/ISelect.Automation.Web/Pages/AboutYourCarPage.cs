using ISelect.Automation.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ISelect.Automation.Web.Pages
{
    public class AboutYourCarPage:BasePage
    {
        public AboutYourCarPage(IAppDriver driver) : base(driver)
        { }


        private void SetDropdownValue(string fieldName, string value)
        {
            Driver.FindElement(By.XPath("//div[text()='"+fieldName+"']/..//input")).SendKeys(value + Keys.Enter);
            Thread.Sleep(1000);
        }

        private bool IsDropDownHasError(string fieldName, string message)
        {
            return Driver.FindElement(By.XPath(("//div[contains(text(),'"+fieldName+"')]/../../../../..//span[text()='"+message+"']"))) != null;
        }

        private void SetOptionValue(string fieldName, string value)
        {
            var container = Driver.FindElements(By.XPath("//div[text()='"+fieldName+"']/../../following-sibling::div"))[0];
            FocusElement(container);
            container.FindElements(By.XPath(".//button")).Single(x => x.Text == value).Click(); 
        }
        
        public void SetFactoryFittedOptionsOption(string value)
        {
            SetOptionValue("Does your car have any factory fitted options?", value);
        }

        public void SetNonStandardAccessoriesOption(string value)
        {
            SetOptionValue("Has your car been fitted with any non-standard accessories?",value);
        }
        public void SetAccidentOrHailDamageOption(string value)
        {
            SetOptionValue("Does your car have unrepaired accident or hail damage?", value);
        }

        public void SetMakeDropdownValue(string value)
        {
            SetDropdownValue("Make", value);
        }

        public void SetModelDropdownValue(string value) => SetDropdownValue("Model", value);
        public bool IsModelDropdownHasError(string value) => IsDropDownHasError("Model", value);


        public void SetYearDropdownValue(string value) => SetDropdownValue("Year", value);
        public bool IsYearDropdownHasError(string value) => IsDropDownHasError("Year", value);


        public void SetCarTypeDropdownValue(string value) => SetDropdownValue("Car type or series", value);
        public bool IsCarTypeDropdownHasError(string value) => IsDropDownHasError("Car type or series", value);


        public void SetColorDropdownValue(string value) => SetDropdownValue("Colour", value);
        public bool IsColorDropdownHasError(string value) => IsDropDownHasError("Colour", value);

        public void SetReasonForCoverDropdownValue(string value)
        {
            Driver.FindElement(By.XPath("//h2[text()='Why are you looking for cover?']/..//div[text()='Please select']")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.XPath("//div[text()='"+value+"']")).Click();
        }
        public bool IsCoverReasonDropdownHasError(string message)
        {
            var element = Driver.FindElements(By.XPath("//h2[contains(text(),'Why are you looking for cover?')]/following-sibling::div"))[1];
            return element.Text.Contains(message);
        }


        public void SetAntiTheftDevicesDropdownValue(string value)
        {
            Driver.FindElement(By.XPath("//div[text()='Does your car have any anti-theft devices?']/..//div[text()='Please select']")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.XPath("//div[text()='" + value + "']")).Click();
        }
        public bool IsAntiTheftDevicesDropdownHasError(string message)
        {
            var element = Driver.FindElements(By.XPath("//div[contains(text(),'Does your car have any anti-theft devices?')]/following-sibling::div"))[0];
            return element.Text.Contains(message);
        }

        public void SetCover(string value)
        {
            var button = Driver.FindElements(By.XPath("//h2[text()='What level of cover are you looking for?']/..//button")).Single(x => x.Text == value);
            JSClick(button);
        }

        public bool IsCoverHasError(string message)
        {
            return Driver.FindElement(By.XPath("//h2[text()='What level of cover are you looking for?']/..//span[text()='" + message + "']")) != null;
        }

        public void SetIsVehicleCurrentlyInsurred(string value)
        {
            Driver.FindElement(By.XPath("//div[text()='Is your vehicle currently insured?']/..//div[text()='Please select']")).Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.XPath("//div[text()='" + value + "']")).Click();
        }

        public void CheckAgreeCheckBox()
        {
            var checkBox = Driver.FindElement(By.XPath("//input[@type='checkbox']"));
            FocusElement(checkBox);
            JSClick(checkBox);
        }

        public void ClickContinueButton() => Driver.FindElement(By.XPath("//button[text()='Continue']")).Click();
    }
}
