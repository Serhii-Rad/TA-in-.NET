using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TAdotNET.PageObjects;
using TAdotNET.Tests;

namespace TAdotNET.Business_Logic_Layer
{
    
    public class BLL : BaseTest
    {
        
        public void OpenSelectedTab(string tabName)
        {
            new HomePage(driver).GoTo(tabName);
            new HomePage(driver).ClickOnLaterButton();
        }

        public void GetSearchedInformation(string text)
        {
            new HomePage(driver).GoTo("News");
            new HomePage(driver).ClickOnLaterButton();
            new NewsPage(driver).ClickOnSearchField();
            new NewsPage(driver).InputInSearchField(text);
            new NewsPage(driver).SearchFieldEnter();
        }

        public void SendYourCOVIDStory(string story, string name, string email, string number, string location)
        {
            new HomePage(driver).GoTo("News");
            new HomePage(driver).ClickOnLaterButton();

            new NewsPage(driver).GoTo(ThemesOfNews.Coronavirus);
            new NewsPage(driver).ClickOnCoronaStory();
            new NewsPage(driver).ClickOnHowToShare();
            new NewsPage(driver).InputStory(story);

            var dict = new Dictionary<string, string>()
            { {"Name", name}, {"Email address", email}, {"Contact number ", number }, {"Location ", location } };
            Form form = new Form(driver);
            form.FillForm(dict);

            GetNewsPage().ClickOnAgeCheckBox();
            GetNewsPage().ClickOnTermsCheckBox();

            GetNewsPage().ClickSubmitButton();
        }
    }
}
