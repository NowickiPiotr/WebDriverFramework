using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverFrameworkUnitTests.AndroidCapabilites;
using WebDriverFrameworkUnitTests.Capabilities;

namespace WebDriverFrameworkUnitTests.BisnodeMobile
{
    [TestFixture]
    public class BisnodeMobileMainSite_UnitTest
    {
        AppiumDriver<IWebElement> driver;

        [SetUp]
        public void Initialize()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            CapabilityManager manager = new CapabilityManager();



            ////******************Chrome**************************//
            capabilities.SetCapability("platformVersion", "6.0");
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability(MobileCapabilityType.App, "Chrome");
            capabilities.SetCapability(CapabilityType.BrowserName, "Android");
            capabilities.SetCapability("deviceName", "CB5A20U0X7");
            ////********************************************//

            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
            driver.Navigate().GoToUrl("http://www.bisnode.pl/");
        }

        [Category("MainSite_Mobile_Chrome")]
        [Test]
        public void AppiumBrowserConfigurationUnitTest()
        {
            Assert.AreEqual("", "");
        }

        [TearDown]
        public void PostConditions()
        {
            driver.Quit();
        }
    }
}
