using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TAdotNET.BDT.Hooks;
using TAdotNET.Business_Logic_Layer;
using TAdotNET.Tests;
using TechTalk.SpecFlow;

namespace TAdotNET
{
    [Binding]
    public class CheckNameOfFirstStory : BLL
    {
        
        [Given(@"Opened News tab")]
        public void GivenOpenedNesTab()
        {
            OpenSelectedTab("News");
        }
        [When(@"Got text from the first story on the page")]
        public string WhenGotTextFromTheFirstStoryOnThePage()
        {
            
            return GetTextFromElement(driver.FindElement(By.XPath("//*[@id]/div/div/div/div[1]/div/div/div[1]/div/a/h3")));
           
        }
        [Then(@"Text should be equal to expected text")]
        public void ThenTextShouldBeEqualToExpectedText()
        {
            Assert.AreEqual("Donald Trump 'paid $750 in federal income taxes'", WhenGotTextFromTheFirstStoryOnThePage());
            driver.Close();
        }
    }
}

