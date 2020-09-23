using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TAdotNET.Tests;
using TechTalk.SpecFlow;

namespace TAdotNET
{
    [Binding]
    public class CheckNameOfFirstStory
    {
        IWebDriver driver = new ChromeDriver();


        [Given(@"Entered BBC home page")]
        public void GivenEnteredBBCHomePage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.bbc.com");
        }
        [Given(@"Clicked on News tab")]
        public void GivenClickedOnNewsTab()
        {
            IWebElement newsButton = driver.FindElement(By.XPath("//nav[@role='navigation']//a[contains(text(), 'News')]"));
            newsButton.Click();
        }
        [Given(@"Closed pop-up window")]
        public void GivenClosedPopUpWindow()
        {
            IWebElement laterButton = driver.FindElement(By.XPath("//div[@class='sign_in-container']//button[@class='sign_in-exit']"));
            laterButton.Click();
        }
        [When(@"Got text from the first story on the page")]
        public string WhenGotTextFromTheFirstStoryOnThePage()
        {
            IWebElement headline = driver.FindElement(By.XPath("//*[@id]/div/div/div/div[1]/div/div/div[1]/div/a/h3"));
            string elementText = headline.Text;
            return elementText;
        }
        [Then(@"Text should be equal to expected text")]
        public void ThenTextShouldBeEqualToExpectedText()
        {
            Assert.AreEqual("Poisoned Navalny discharged from Berlin hospital", WhenGotTextFromTheFirstStoryOnThePage());
            driver.Close();
        }
    }
}

//namespace GoogleSearch.GoogleSearch
//{
//    [Binding]
//    public class GoogleKeyWordSearchSteps
//    {
//        IWebDriver driver = new ChromeDriver();
//        [Given(@"I have entered the Google Home page")]
//        public void GivenIHaveEnteredTheGoogleHomePage()
//        {
//            driver.Navigate().GoToUrl("https://www.google.co.nz");
//        }

//        [Given(@"I have entered spec flow into google search bar")]
//        public void GivenIHaveEnteredSpecFlowIntoGoogleSearchBar()
//        {
//            driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div[2]/div[1]/div[1]/div[3]/div/div[3]/div/input[1]")).SendKeys("Spec Flow");
//        }

//        [When(@"I press search button")]
//        public void WhenIPressSearchButton()
//        {
//            driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div[3]/center/input[1]")).Click();
//        }

//        [Then(@"the result should be a new pages with results for spec flow")]
//        public void ThenTheResultShouldBeANewPagesWithResultsForSpecFlow()
//        {
//            Assert.AreEqual("Google", driver.Title);
//        }
//    }
//}