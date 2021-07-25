using ISelect.Automation.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISelect.Automation.Web.Pages
{
    public class UsageAndDriverPage : BasePage
    {
        public UsageAndDriverPage(IAppDriver driver) : base(driver)
        { }

        public bool IsPageHeadingPresent()
        {
            if (Driver.FindElement(By.XPath("//h1[text()='Usage & Driver']")) != null)
            { 
                return true; 
            }
            return false;
        }
    }
}
