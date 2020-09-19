using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;


namespace TAdotNET.Tests
{
    [TestClass]
    public class Test1 : BaseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            GetHomePage().ClickOnNewsButton();
            GetHomePage().ClickOnLaterButton();
            

            Assert.AreEqual("India's coronavirus cases surge past five million", GetNewsPage().GetHeadlineText());
            

        }
        
    }
}
