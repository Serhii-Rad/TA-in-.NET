using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TAdotNET.Elements;
using TAdotNET.PageObjects;
using TAdotNET.Tests;

namespace TAdotNET.Business_Logic_Layer
{
    
    public class BLL
    {
        public IWebDriver driver;

        //public static T GetPages<T>() where T : new()
        //{

        //    var page = new T();

        //    return page;
        //}
        public void OpenSelectedTab(string tabName)
        {
            var homePage = new HomePage(driver);
            homePage.GoTo(tabName);
            homePage.ClickOnLaterButton();
        }
        
        public void GetSearchedInformation(string text)
        {
            var homePage = new HomePage(driver);
            var newsPage = new NewsPage(driver);
            homePage.GoTo("News");
            homePage.ClickOnLaterButton();
            newsPage.ClickOnSearchField();
            newsPage.InputInSearchField(text);
            newsPage.SearchFieldEnter();
        }

        public string GetTextFromElement(IWebElement element)
        {
            return element.Text;
        }
        public void SendYourCOVIDStory(string story, string name, string email, string number, string location)
        {
            var homePage = new HomePage(driver);
            var newsPage = new NewsPage(driver);
            homePage.GoTo("News");
            homePage.ClickOnLaterButton();

            newsPage.GoTo(ThemesOfNews.Coronavirus);
            newsPage.ClickOnCoronaStory();
            newsPage.ClickOnHowToShare();
            newsPage.InputStory(story);

            var dict = new Dictionary<string, string>()
            { {"Name", name}, {"Email address", email}, {"Contact number ", number }, {"Location ", location } };
            Form form = new Form(driver);
            form.FillForm(dict);

            newsPage.ClickOnAgeCheckBox();
            newsPage.ClickOnTermsCheckBox();

            newsPage.ClickSubmitButton();
        }
    }
}
