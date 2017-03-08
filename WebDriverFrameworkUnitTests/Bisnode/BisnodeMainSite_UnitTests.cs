using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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
        WebDriverWait wait;


        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver(@"C:\chromedriver_win32");
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.bisnode.pl/");
           
            wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(30));
            actions = new Actions(PropertiesCollection.driver);
            bisnode = bisnodeMainSiteFactory();

        }
        [Test]
        public void SliderTest()
        {

            actions.DoubleClick(bisnode.Slider_left_ClassName).Perform();
            actions.DoubleClick(bisnode.Slider_left_ClassName).Perform();
            bisnode.Slider_left_ClassName.Click();
            bisnode.Green_ClassName.Click();
      
        }



        [Test]
        public void EmailFormInFoot_NoText_InvalidDataMessage()
        {
            String handle = PropertiesCollection.driver.CurrentWindowHandle;
            bisnode.S_email_Name.Click();
            bisnode.S_email_Name.SendKeys(Keys.Return);
            PropertiesCollection.driver.SwitchTo().Window(handle);
            //sendKeys(Keys.RETURN);
           // actions.KeyDown(Keys.Enter).();
        }


        [Test]
        public void CssSelectorTest_findSaveButton_Click()
        {
            bisnode.Save_button_CSSSelector.Click();

        }

        [Test]
        public void alert_test()
        {
        //    IAlert alert = PropertiesCollection.driver.SwitchTo().Alert();
        //    alert.Accept();
        //    PropertiesCollection.driver.SwitchTo().DefaultContent();

        }

        [Test]
        public void Navigation_sub_navigation_GoToTest()
        {
            //PropertiesCollection.driver.FindElement(By.LinkText("Blog")).Click();
            

            bisnode.Blog_LinkText.Click();
            PropertiesCollection.driver.Navigate().Back();


            bisnode.Rankings_LinkText.Click();
            PropertiesCollection.driver.Navigate().Back();

            bisnode.They_trusted_us_LinkText.Click();
            PropertiesCollection.driver.Navigate().Back();
        }

        [Test]
        public void FindSaveButton_ByXpath()
        {
            bisnode.SaveButton_XPath.Click();
            
        }

        [Test]
        public void explictTest()
        { 
        IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.ClassName("green")));
        myDynamicElement.Click();
        }

        [Test]
        public void CheckCountry_CheckCzechy_OpenTab()
        {
            bisnode.Country_Name.SelectDropDownElementByText("Czechy");
        }





        [TearDown]
        public void PostConditions()
        {
            //close() – it will close the browser where the control is.
            //quit() – it will close all the browsers opened by WebDriver.
            
                        
               PropertiesCollection.driver.Close();
        }
    }
}
