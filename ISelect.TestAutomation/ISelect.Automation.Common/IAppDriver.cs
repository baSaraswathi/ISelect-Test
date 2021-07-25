using OpenQA.Selenium;
using System;

namespace ISelect.Automation.Common
{
    public interface IAppDriver : IWebDriver
    {
        IAppLogger Logger { get; set; }        
    }
}
