using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using UnitTestProject2.PageObjects;

namespace TAdotNET
{
    public class NewsPage : BasePage
    {
        public NewsPage(IWebDriver driver) : base(driver)
        {

        }


        [FindsBy(How = How.XPath, Using = "//nav[@role='navigation']//a[contains(text(), 'News')]")]
        public IWebElement headline;
        
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'gel-wrap gs-u-pt+')]//div[contains(@class, 'secondary-item')]//h3")]
        public IList<IWebElement> themesList;

        [FindsBy(How = How.XPath, Using = "//div[@class='gs-c-promo-body gel-1/2@xs gel-1/1@m gs-u-mt@m']//a/h3[1]")]
        public IWebElement firstArticle;
        
        [FindsBy(How = How.XPath, Using = "//input[@id='orb-search-q']")]
        public IWebElement searchField;
                
        [FindsBy(How = How.XPath, Using = "//a//span[@aria-hidden='false']")]
        public IWebElement searchedArticle;
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/header/div[2]/div[1]/div[1]/nav/ul/li[3]/a")]
        public IWebElement coronavirusTab;

        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/header/div[2]/div[2]/div[1]/nav/ul/li[2]/a")]
        public IWebElement coronavirusStoryTab;
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[7]/div/div[2]/div/div[2]/div[2]/div[1]/div/div[2]/div/a")]
        public IWebElement howToShare;
        
        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder]")]
        public IWebElement storyField;
        
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Name']")]
        public IWebElement nameField;
        
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email address']")]
        public IWebElement emailField;
        
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Contact number ']")]
        public IWebElement numberField;
        
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Location ']")]
        public IWebElement locationField;
        
        [FindsBy(How = How.XPath, Using = "//button[contains(text(), 'Submit')]")]
        public IWebElement submitButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[6]/div/div[5]/div[1]/div[2]/div/div[1]/div[1]/div[2]/div[2]/div/div/div[1]/div[6]/label/input")]
        public IWebElement ageCheckBox;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'input-error')]")]
        public IWebElement errorMessage;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[6]/div/div[5]/div[1]/div[2]/div/div[1]/div[1]/div[2]/div[2]/div/div/div[1]/div[7]/label/input")]
        public IWebElement termsCheckBox;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Email address is invalid')]")]
        public IWebElement errorMessageText;



        public void ClickSubmitButton()
        {
            submitButton.Click();
        }

        public string GetHeadlineText()
        {
            return headline.Text;
        }

        public IList<IWebElement> GetThemeList()
        {
            return themesList;
        }

        public string GetFirstArticleName()
        {
            return firstArticle.Text;
        }
        public void ClickOnSearchField()
        {
            searchField.Click();
        }
        public void EnterFirstArticleName()
        {
            searchField.SendKeys(firstArticle.Text);
        }
        public void SearchFieldEnter()
        {
            searchField.SendKeys(Keys.Enter);
        }
        public string SearchedArticleName()
        {
            return searchedArticle.Text;
        }
        public void ClickOnCoronavirusTab()
        {
            coronavirusTab.Click();
        }
        public void ClickOnCoronaStory()
        {
            coronavirusStoryTab.Click();
        }
        public void ClickOnHowToShare()
        {
            howToShare.Click();
        }
        public void InputStory(string story)
        {
            storyField.SendKeys(story);
        }
        public void InputName(string name)
        {
            nameField.SendKeys(name);
        }
        public void InputEmail(string email)
        {
            emailField.SendKeys(email);
        }
        public void InputNumber(string number)
        {
            numberField.SendKeys(number);
        }
        public void InputLocation(string location)
        {
            locationField.SendKeys(location);
        }
        public void ClickOnAgeCheckBox()
        {
            ageCheckBox.Click();
        }
        public void ClickOnTermsCheckBox()
        {
            termsCheckBox.Click();
        }
        public IWebElement GetErrorMessage()
        {
            return errorMessage;
        }
        public string GetErrorMessageText()
        {
            return errorMessageText.Text;
        }
    }
}
