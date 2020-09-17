using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;


namespace UnitTestProject2.PageObjects
{
    public class BasePage
    {
        IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
        
        public void Refresh()
        {
            driver.Navigate().Refresh();
        }


    }
}
