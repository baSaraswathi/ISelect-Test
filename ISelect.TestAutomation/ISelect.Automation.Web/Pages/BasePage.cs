using ISelect.Automation.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ISelect.Automation.Web.Pages
{
    public class BasePage
    {
        public IAppDriver Driver;
        public BasePage(IAppDriver driver) 
        {
            this.Driver = driver;
        }

        public void Navigate(string Url)
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(Url);
        }

        protected void FocusElement(IWebElement webElement)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", webElement);
            Thread.Sleep(1500);
        }

        protected void JSClick(IWebElement webElement)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", webElement);
            Thread.Sleep(1500);
        }
    }
}
