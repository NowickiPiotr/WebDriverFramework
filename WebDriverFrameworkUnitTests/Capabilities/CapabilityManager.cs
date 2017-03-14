using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverFrameworkUnitTests.Capabilities;

namespace WebDriverFrameworkUnitTests.AndroidCapabilites
{
    public sealed class CapabilityManager
    {

       

        public DevicePlatform Platform { get; set; }
        public string PlatformVersion { get; set; }
        public string BrowserName { get; set; }
        
        public string DeviceName { get; set; }

        public CapabilityManager()
        {
        }

        public void AssignAppiumCapabilities(ref DesiredCapabilities appiumCapabilities)
        {
        }
    }
}
