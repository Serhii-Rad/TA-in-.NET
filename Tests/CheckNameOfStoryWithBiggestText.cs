using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;


namespace TAdotNET.Tests
{
    [TestClass]
    public class CheckNameOfStoryWithBiggestText : BaseTest
    {
        [TestMethod]
        public void TestMethod1()
        {


            GetHomePage().GoTo("News");
            GetHomePage().ClickOnLaterButton();
            

            Assert.AreEqual("Poisoned Navalny discharged from Berlin hospital", GetNewsPage().GetHeadlineText());
            

        }
        
    }
}
