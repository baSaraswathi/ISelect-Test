using ISelect.Automation.Web.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit;

namespace ISelect.Test.Steps
{
    [Binding]
    public class CompareInsuranceSteps : ISelectBaseSteps
    {
        public CompareInsuranceSteps(FeatureContext context) : base(context)
        { }

        [Then(@"I expect I am navigated to Usage & Driver page")]
        public void GivenILanuchedCompare_Car_InsurancePage()
        {
            var page = new UsageAndDriverPage(AppDriver);
            Assert.True(page.IsPageHeadingPresent());
        }
    }
}
