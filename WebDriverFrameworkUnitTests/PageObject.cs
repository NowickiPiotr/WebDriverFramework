using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverFrameworkUnitTests
{
    public class PageObjectExample
    {
        public PageObjectExample()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How=How.ClassName, Using = "group-button")]
        public IWebElement Group_ButtonClassName { get; set; }
    }
}
