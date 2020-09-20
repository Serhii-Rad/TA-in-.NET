using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TAdotNET.PageObjects;

namespace TAdotNET.Tests
{
    [TestClass]
    public class CheckSendingStoryWithIncorrectEmail : BaseTest
    {

        [TestMethod]
        public void TestMethod4()
        {

            GetHomePage().GoTo("News");
            GetHomePage().ClickOnLaterButton();

            GetNewsPage().GoTo(ThemesOfNews.Coronavirus);
            GetNewsPage().ClickOnCoronaStory();
            GetNewsPage().ClickOnHowToShare();
            GetNewsPage().InputStory("Story about Covid");
            
            var dict = new Dictionary<string, string>()
            { {"Name", "User name"}, {"Email address", "emailmail.com"}, {"Contact number ", "2281488" }, {"Location ", "Kyiv" } };
            Form form = new Form(driver);
            form.FillForm(dict);

            GetNewsPage().ClickOnAgeCheckBox();
            GetNewsPage().ClickOnTermsCheckBox();

            GetNewsPage().ClickSubmitButton();

            Assert.IsTrue(GetNewsPage().GetErrorMessageText().Contains("Email address is invalid"), "There is no message about invalid Email address");
        }
    }
}
