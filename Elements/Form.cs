using System;
using System.Collections.Generic;
using System.Text;
using TAdotNET.PageObjects;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Chrome;

namespace TAdotNET.Elements
{
    public class Form : BasePage
    {
       public Form(IWebDriver driver) : base(driver)
        { 
        }
        
        private IWebElement GetFormElement(string field) => driver.FindElement(By.XPath($"//*[@placeholder='{field}']"));
        public void FillForm(Dictionary<string, string> fields)
        {
            foreach (var key in fields.Keys)
            {
                GetFormElement(key).SendKeys(fields[key]);
            }
        }


    }
}
