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

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();  // Creates a new Chrome instance and opens the browser
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.bbc.com");  // Navigates to a page by address

            IWebElement element = driver.FindElement(By.XPath("//nav[@role='navigation']//a[contains(text(), 'News')]")); // Replace “xpath” with correct xpath. This returns an IWebElement interface of the element found by Xpath. This interface can then be used to click the element or perform other actions (such as getting its text, checking visibility).
            element.Click(); // Clicks the element


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement laterButton = driver.FindElement(By.XPath("//div[@class='sign_in-container']//button[@class='sign_in-exit']"));
            laterButton.Click();

            IWebElement headline = driver.FindElement(By.XPath("//*[@id='u5980633282889429']/div/div/div/div[1]/div/div/div[1]/div/a/h3"));
            string elementText = headline.Text; // Assigns the text in the element (which is usually what you see on this element in your browser) to variable elementText
            Assert.AreEqual("India's coronavirus cases surge past five million", elementText);  // Checks that string “text” is equal to variable elementText, and throws exception if not. Use for checks that must succeed for the test to pass (i.e. the checks that are the purpose of the test).

            driver.Close();
        }
        [TestMethod]
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.bbc.com");

            IWebElement newsButton = driver.FindElement(By.XPath("//nav[@role='navigation']//a[contains(text(), 'News')]"));
            newsButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement laterButton = driver.FindElement(By.XPath("//div[@class='sign_in-container']//button[@class='sign_in-exit']"));
            laterButton.Click();

            var themesList = driver.FindElements(By.XPath("//div[contains(@class, 'gel-wrap gs-u-pt+')]//div[contains(@class, 'secondary-item')]//h3"));
            List<string> themesNames = new List<string> { "Trump denies minimising Covid risk: I 'up-played' it",
                "The health risks of wildfire smoke",
                "The unexpected rise of Japan's new prime minister",
                "Barbados to remove Queen as head of state",
                "New Melania Trump statue replaces burnt original" };
            int i = 0;


            foreach (IWebElement element in themesList)
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//div[contains(@class, 'gel-wrap gs-u-pt+')]//div[contains(@class, 'secondary-item')]//h3")).Displayed);

                Assert.IsTrue(element.Text.Contains(themesNames[i]));
                i++;
            }

            driver.Close();
        }
        [TestMethod]
        public void TestMethod3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.bbc.com");

            IWebElement newsButton = driver.FindElement(By.XPath("//nav[@role='navigation']//a[contains(text(), 'News')]"));
            newsButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement laterButton = driver.FindElement(By.XPath("//div[@class='sign_in-container']//button[@class='sign_in-exit']"));
            laterButton.Click();

            IWebElement firstArticle = driver.FindElement(By.XPath("//div[@class='gs-c-promo-body gel-1/2@xs gel-1/1@m gs-u-mt@m']//a/h3[1]"));
            string firstArticleName = firstArticle.Text;

            IWebElement searchField = driver.FindElement(By.XPath("//input[@id='orb-search-q']"));
            searchField.Click();

            searchField.SendKeys(firstArticleName);
            searchField.SendKeys(Keys.Enter);

            

            IWebElement searchedArticle = driver.FindElement(By.XPath("//a//span[@aria-hidden='false']"));
            string nameOfSearchedArticle = searchedArticle.Text;

            Assert.AreEqual(nameOfSearchedArticle, firstArticleName);


            driver.Close();
        }
        [TestMethod]
        public void TestMethod4()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.bbc.com");

            IWebElement newsButton = driver.FindElement(By.XPath("//nav[@role='navigation']//a[contains(text(), 'News')]"));
            newsButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement laterButton = driver.FindElement(By.XPath("//div[@class='sign_in-container']//button[@class='sign_in-exit']"));
            laterButton.Click();

            IWebElement coronavirusTab = driver.FindElement(By.XPath("/html/body/div[7]/header/div[2]/div[1]/div[1]/nav/ul/li[3]/a"));
            coronavirusTab.Click();


            IWebElement coronavirusStoryTab = driver.FindElement(By.XPath("/html/body/div[7]/header/div[2]/div[2]/div[1]/nav/ul/li[2]/a"));
            coronavirusStoryTab.Click();



            IWebElement howToShare = driver.FindElement(By.XPath("/html/body/div[7]/div/div[2]/div/div[2]/div[2]/div[1]/div/div[2]/div/a"));
            howToShare.Click();




            IWebElement storyField = driver.FindElement(By.XPath("//textarea[@placeholder]"));
            storyField.SendKeys("Story about Covid");
            IWebElement nameField = driver.FindElement(By.XPath("//input[@placeholder='Name']"));
            nameField.SendKeys("User name");
            IWebElement emailField = driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
            emailField.SendKeys("emailmail.com");
            IWebElement numberField = driver.FindElement(By.XPath("//input[@placeholder='Contact number ']"));
            numberField.SendKeys("2281488");
            IWebElement locationField = driver.FindElement(By.XPath("//input[@placeholder='Location ']"));
            locationField.SendKeys("Kyiv");
            IWebElement ageCheckBox = driver.FindElement(By.XPath("/html/body/div[2]/div[6]/div/div[5]/div[1]/div[2]/div/div[1]/div[1]/div[2]/div[2]/div/div/div[1]/div[6]/label/input"));
            ageCheckBox.Click();
            IWebElement termsCheckBox = driver.FindElement(By.XPath("/html/body/div[2]/div[6]/div/div[5]/div[1]/div[2]/div/div[1]/div[1]/div[2]/div[2]/div/div/div[1]/div[7]/label/input"));
            termsCheckBox.Click();



            IWebElement submitButton = driver.FindElement(By.XPath("//button[contains(text(), 'Submit')]"));
            submitButton.Click();



            Assert.IsTrue(driver.FindElement(By.XPath("//div[contains(@class, 'input-error')]")).Text.Contains("Email address is invalid"));

            driver.Close();
        }

        [TestMethod]
        public void TestMethod5()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.bbc.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement newsButton = driver.FindElement(By.XPath("//nav[@role='navigation']//a[contains(text(), 'News')]"));
            newsButton.Click();



            IWebElement laterButton = driver.FindElement(By.XPath("//div[@class='sign_in-container']//button[@class='sign_in-exit']"));
            laterButton.Click();

            IWebElement coronavirusTab = driver.FindElement(By.XPath("/html/body/div[7]/header/div[2]/div[1]/div[1]/nav/ul/li[3]/a"));
            coronavirusTab.Click();



            IWebElement coronavirusStoryTab = driver.FindElement(By.XPath("/html/body/div[7]/header/div[2]/div[2]/div[1]/nav/ul/li[2]/a"));
            coronavirusStoryTab.Click();



            IWebElement howToShare = driver.FindElement(By.XPath("/html/body/div[7]/div/div[2]/div/div[2]/div[2]/div[1]/div/div[2]/div/a"));
            howToShare.Click();




            IWebElement storyField = driver.FindElement(By.XPath("//textarea[@placeholder]"));
            storyField.SendKeys("Story about Covid");
            IWebElement nameField = driver.FindElement(By.XPath("//input[@placeholder='Name']"));
            nameField.SendKeys("User name");
            IWebElement emailField = driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
            emailField.SendKeys("email@mail.com");
            IWebElement numberField = driver.FindElement(By.XPath("//input[@placeholder='Contact number ']"));
            numberField.SendKeys("2281488");
            IWebElement locationField = driver.FindElement(By.XPath("//input[@placeholder='Location ']"));
            locationField.SendKeys("Kyiv");
            IWebElement ageCheckBox = driver.FindElement(By.XPath("/html/body/div[2]/div[6]/div/div[5]/div[1]/div[2]/div/div[1]/div[1]/div[2]/div[2]/div/div/div[1]/div[6]/label/input"));
            ageCheckBox.Click();

           

            IWebElement submitButton = driver.FindElement(By.XPath("//button[contains(text(), 'Submit')]"));
            submitButton.Click();





            Assert.IsTrue(driver.FindElement(By.XPath("//div[contains(@class, 'input-error')]")).Displayed);

            driver.Close();
        }

        [TestMethod]
        public void TestMethod6()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.bbc.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement newsButton = driver.FindElement(By.XPath("//nav[@role='navigation']//a[contains(text(), 'News')]"));
            newsButton.Click();



            IWebElement laterButton = driver.FindElement(By.XPath("//div[@class='sign_in-container']//button[@class='sign_in-exit']"));
            laterButton.Click();

            IWebElement coronavirusTab = driver.FindElement(By.XPath("/html/body/div[7]/header/div[2]/div[1]/div[1]/nav/ul/li[3]/a"));
            coronavirusTab.Click();



            IWebElement coronavirusStoryTab = driver.FindElement(By.XPath("/html/body/div[7]/header/div[2]/div[2]/div[1]/nav/ul/li[2]/a"));
            coronavirusStoryTab.Click();



            IWebElement howToShare = driver.FindElement(By.XPath("/html/body/div[7]/div/div[2]/div/div[2]/div[2]/div[1]/div/div[2]/div/a"));
            howToShare.Click();





            IWebElement nameField = driver.FindElement(By.XPath("//input[@placeholder='Name']"));
            nameField.SendKeys("User name");
            IWebElement emailField = driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
            emailField.SendKeys("email@mail.com");
            IWebElement numberField = driver.FindElement(By.XPath("//input[@placeholder='Contact number ']"));
            numberField.SendKeys("2281488");
            IWebElement locationField = driver.FindElement(By.XPath("//input[@placeholder='Location ']"));
            locationField.SendKeys("Kyiv");
            IWebElement ageCheckBox = driver.FindElement(By.XPath("/html/body/div[2]/div[6]/div/div[5]/div[1]/div[2]/div/div[1]/div[1]/div[2]/div[2]/div/div/div[1]/div[6]/label/input"));
            ageCheckBox.Click();
            IWebElement termsCheckBox = driver.FindElement(By.XPath("/html/body/div[2]/div[6]/div/div[5]/div[1]/div[2]/div/div[1]/div[1]/div[2]/div[2]/div/div/div[1]/div[7]/label/input"));
            termsCheckBox.Click();

            

            IWebElement submitButton = driver.FindElement(By.XPath("//button[contains(text(), 'Submit')]"));
            submitButton.Click();


            

            Assert.IsTrue(driver.FindElement(By.XPath("//div[contains(@class, 'input-error')]")).Displayed);

            driver.Close();
        }


       


    }
}
