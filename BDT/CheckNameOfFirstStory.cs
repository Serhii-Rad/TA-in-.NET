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

