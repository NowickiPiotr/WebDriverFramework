using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverFrameworkUnitTests
{
   public class BisnodeBasicNavigation
    {
        public BisnodeBasicNavigation()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

       [FindsBy(How = How.ClassName, Using = "group-button")]
       public IWebElement Group_ButtonClassName { get; set; } 

        [FindsBy(How = How.Name, Using = "s")]
        public IWebElement s_Name { get; set; }

        [FindsBy(How = How.Name, Using = "country")]
        public IWebElement CountryDropDown { get; set; }





        public void EnterTextInSearchForm(string value)
        {
            s_Name.EnterText(value);
            //SeleniumMethods.EnterText(s_Name,value);
        }
        public void GroupButtonClick()
        {
            //SeleniumMethods.ClickOn(Group_ButtonClassName);
            Group_ButtonClassName.ClickOn();
        }
        public void SelectCountryByName(string value)
        {
            CountryDropDown.SelectDropDownElementByText(value);
           // SeleniumMethods.SelectDropDownElementByText(CountryDropDown, value);
        }
        public string GetCountryText()
        {
            return CountryDropDown.GetText();
          // return SeleniumMethods.GetText(CountryDropDown);
        }
        public string getCountrFromDDL()
        {
            return CountryDropDown.GetSingleOrDefaultTextFromDDl();
           // return SeleniumMethods.GetSingleOrDefaultTextFromDDl(CountryDropDown);
        }
        public PageObjectExample SiteNavigation()
        {
            Group_ButtonClassName.ClickOn();
            return new PageObjectExample();
        }
    }
}
