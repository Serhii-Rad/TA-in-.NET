using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TAdotNET.Elements;
using TAdotNET.PageObjects;

namespace TAdotNET.Tests
{
    [TestClass]
    public class CheckSendingStoryWithoutTermsCheckBox : BaseTest
    {
        [TestMethod]
        public void TestMethod5()
        {

            GetHomePage().GoTo("News");
            GetHomePage().ClickOnLaterButton();

            GetNewsPage().GoTo(ThemesOfNews.Coronavirus);
            GetNewsPage().ClickOnCoronaStory();
            GetNewsPage().ClickOnHowToShare();
            GetNewsPage().InputStory("Some story");
            
            var dict = new Dictionary<string, string>()
            { {"Name", "User name"}, {"Email address", "email@mail.com"}, {"Contact number ", "2281488" }, {"Location ", "Kyiv" } };
            Form form = new Form(driver);
            form.FillForm(dict);

            GetNewsPage().ClickOnAgeCheckBox();
            
            GetNewsPage().ClickSubmitButton();

            Assert.IsTrue(GetNewsPage().GetErrorMessage().Displayed, "There is no Error message");
        }
    }
}
