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
using TAdotNET.PageObjects;

namespace TAdotNET.Tests
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
            var dict = new Dictionary<string, string>()
            { {"Name", "Vasya"}, {"Email address", "my@email.com"}, {"Contact number ", "2281488" }, {"Location ", "Kyiv" } };
            Form form = new Form(driver);
            form.FillForm(dict);
            GetNewsPage().ClickOnAgeCheckBox();
            GetNewsPage().ClickOnTermsCheckBox();


            GetNewsPage().ClickSubmitButton();

            Assert.IsTrue(GetNewsPage().GetErrorMessage().Displayed, "There is no Error message");
        }
    }
}
