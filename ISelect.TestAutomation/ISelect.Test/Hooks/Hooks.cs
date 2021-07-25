using ISelect.Test.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ISelect.Test.Hooks
{

    [Binding]
    public class Hooks : ISelectBaseSteps
    {
        public Hooks(FeatureContext context) : base(context)
        {
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            if(AppDriver!=null)
                AppDriver.Dispose();
        }
    }
}
