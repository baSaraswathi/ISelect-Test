using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;

namespace ISelect.Automation.Common
{
    public class AppChromeDriver : ChromeDriver, IAppDriver
    {
        public AppChromeDriver(ChromeDriverService service, ChromeOptions options) : base(service, options)
        { }

        public IAppLogger Logger { get; set; }
    }
}
