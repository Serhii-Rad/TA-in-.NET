using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TAdotNET.Tests
{
    [TestClass]
    public class Test5 : BaseTest
    {
        [TestMethod]
        
        //[DataRow(15)]
        //[DataRow(35)]
        public void TestMethod5()
        {
            GetHomePage().ClickOnNewsButton();
            GetHomePage().ClickOnLaterButton();
            GetNewsPage().ClickOnCoronavirusTab();
            GetNewsPage().ClickOnCoronaStory();
            GetNewsPage().ClickOnHowToShare();
            GetNewsPage().InputStory("Some story");
            GetNewsPage().InputName("User name");
            GetNewsPage().InputEmail("email@mail.com");
            GetNewsPage().InputNumber("2281488");
            GetNewsPage().InputLocation("Kyiv");
            GetNewsPage().ClickOnAgeCheckBox();
            

            GetNewsPage().ClickSubmitButton();

            Assert.IsTrue(GetNewsPage().GetErrorMessage().Displayed, "There is no Error message");
        }
    }
}
