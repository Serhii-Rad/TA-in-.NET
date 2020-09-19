using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TAdotNET.Tests
{
    [TestClass]
    public class Test4 : BaseTest
    {

        [TestMethod]
        public void TestMethod4()
        {
            GetHomePage().ClickOnNewsButton();
            GetHomePage().ClickOnLaterButton();
            GetNewsPage().ClickOnCoronavirusTab();
            GetNewsPage().ClickOnCoronaStory();
            GetNewsPage().ClickOnHowToShare();
            GetNewsPage().InputStory("Story about Covid");
            GetNewsPage().InputName("User name");
            GetNewsPage().InputEmail("emailmail.com");
            GetNewsPage().InputNumber("2281488");
            GetNewsPage().InputLocation("Kyiv");
            GetNewsPage().ClickOnAgeCheckBox();
            GetNewsPage().ClickOnTermsCheckBox();

            GetNewsPage().ClickSubmitButton();

            Assert.IsTrue(GetNewsPage().GetErrorMessageText().Contains("Email address is invalid"), "There is no message about invalid Email address");
        }
    }
}
