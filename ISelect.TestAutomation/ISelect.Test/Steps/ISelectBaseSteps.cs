using ISelect.Automation.Common;
using ISelect.Automation.Web.Pages;
using NLog;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ISelect.Test.Steps
{
    public class ISelectBaseSteps : IDisposable
    {
        public static IAppDriver AppDriver { get; set; }
        private ChromeDriverService chromeDriverService;
        public IAppLogger Logger { get; private set; }
        public ISelectBaseSteps(FeatureContext context)
        {
            if (context.TryGetValue("_driver", out IAppDriver _)==false)
            {
                Logger =  new AppLogger(LogManager.GetLogger("ISelectBaseSteps"), "ISelectBaseSteps");
                InitDriver();
                context.Set(AppDriver,"_driver");
            }
            else
            {
                AppDriver = context.Get<IAppDriver>("_driver");
            }

        }

        private void InitDriver()
        {
            InitChromeDriver();
        }

        public void InitChromeDriver()
        {
            Logger.Info("InitChromeDriver");

           

            chromeDriverService = ChromeDriverService.CreateDefaultService();

            var options = new ChromeOptions();
            if (System.Environment.GetEnvironmentVariable("USEHEADLESS") == "1")
            {
                Logger.Info("Using Headless browser");

                options.AddArgument("--headless");
            }
            options.AcceptInsecureCertificates = true;
            AppDriver = new AppChromeDriver(chromeDriverService, options);
            AppDriver.Logger = Logger;
            Logger.Info("InitChromeDriver End");
        }

        public void Dispose()
        {
           // AppDriver.Dispose();
        }
    }
}
