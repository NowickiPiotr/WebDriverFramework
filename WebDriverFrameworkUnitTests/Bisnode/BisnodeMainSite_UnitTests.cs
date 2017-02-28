using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace WebDriverFrameworkUnitTests.Bisnode.POM
{
    [TestFixture]
    public class BisnodeMainSite_UnitTests
    {
        private BisnodeMainSite bisnodeMainSiteFactory()
        {
            return new BisnodeMainSite();
        }
        BisnodeMainSite bisnode;
        Actions actions;

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver(@"C:\chromedriver_win32");
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.bisnode.pl/");
            actions = new Actions(PropertiesCollection.driver);

            bisnode = bisnodeMainSiteFactory();

        }
        [Test]
        public void SliderTest()
        {

            actions.DoubleClick(bisnode.slider_left_ClassName).Perform();
            actions.DoubleClick(bisnode.slider_left_ClassName).Perform();
            bisnode.slider_left_ClassName.Click();

            bisnode.green_ClassName.Click();
      
        }

        [Test]
        public void EmailFormInFoot_NoText_InvalidDataMessage()
        {
            String handle = PropertiesCollection.driver.CurrentWindowHandle;
            bisnode.s_email_Name.Click();
            bisnode.s_email_Name.SendKeys(Keys.Return);
            PropertiesCollection.driver.SwitchTo().Window(handle);
            //sendKeys(Keys.RETURN);
           // actions.KeyDown(Keys.Enter).();
        }

        [TearDown]
        public void PostConditions()
        {
         //   PropertiesCollection.driver.Close();
        }
    }
}
