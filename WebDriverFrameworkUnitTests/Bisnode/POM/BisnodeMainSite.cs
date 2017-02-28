using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverFrameworkUnitTests.Bisnode.POM
{
    public class BisnodeMainSite
    {
        public BisnodeMainSite()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        //Site under test
        //http://www.bisnode.pl/

        [FindsBy(How = How.ClassName, Using = "slider-right")]
        public IWebElement slider_right_ClassName { get; set; }

        [FindsBy(How = How.ClassName, Using = "slider-left")]
        public IWebElement slider_left_ClassName { get; set; }

        [FindsBy(How = How.ClassName, Using = "blue")]
        public IWebElement blue_ClassName { get; set; }

        [FindsBy(How = How.ClassName, Using = "green")]
        public IWebElement green_ClassName { get; set; }

        [FindsBy(How = How.Name, Using = "s_email")]
        public IWebElement s_email_Name { get; set; }


        
    }
}
