using ISelect.Automation.Web.Pages;
using OpenQA.Selenium;
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
    public class CommonSteps : ISelectBaseSteps
    {
        public CommonSteps(FeatureContext context) : base(context)
        { }

        
    }
}
