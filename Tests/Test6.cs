using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using System.ComponentModel.DataAnnotations;


namespace UnitTestProject2.Tests
{
    [TestClass]
    public class Test6 : BaseTest
    {

        [TestMethod]
        public void TestMethod6()
        {
            GetHomePage().ClickOnNewsButton();
            GetHomePage().ClickOnLaterButton();
            GetNewsPage().ClickOnCoronavirusTab();
            GetNewsPage().ClickOnCoronaStory();
            GetNewsPage().ClickOnHowToShare();
            GetNewsPage().InputStory("");
            GetNewsPage().InputName("User name");
            GetNewsPage().InputEmail("email@mail.com");
            GetNewsPage().InputNumber("2281488");
            GetNewsPage().InputLocation("Kyiv");
            GetNewsPage().ClickOnAgeCheckBox();
            GetNewsPage().ClickOnTermsCheckBox();


            GetNewsPage().ClickSubmitButton();

            Assert.IsTrue(GetNewsPage().GetErrorMessage().Displayed, "There is no Error message");
        }
    }
}
