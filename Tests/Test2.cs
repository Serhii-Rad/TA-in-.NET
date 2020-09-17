using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace UnitTestProject2.Tests
{
    [TestClass]
    public class Test2 : BaseTest
    {
        
        [TestMethod]
        public void TestMethod2()
        {
            GetHomePage().ClickOnNewsButton();
            GetHomePage().ClickOnLaterButton();

            List<string> themesNames = new List<string> { "UK teachers 'must get priority access to tests",
                "UN accuses Venezuela of crimes against humanity",
                "Smoke from US wildfires spreads across country",
                "Self-driving car operator charged over fatal crash",
                "Barbados to remove Queen as head of state" };
            int i = 0;

            foreach (IWebElement element in GetNewsPage().GetThemeList())
            {
                Assert.IsTrue(element.Displayed);
                Assert.IsTrue(element.Text.Contains(themesNames[i]));
                i++;
            }

            
        }
    }
}
