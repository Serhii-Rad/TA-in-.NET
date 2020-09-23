using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Support.UI;
using System;
using TAdotNET.PageObjects;
using SeleniumExtras.PageObjects;


namespace TAdotNET
{
    public enum Tabs
    {
        News,
        Sport,
        Reel,
        Workife,
        Travel,
        Future,
        Culture,
        More
    }
    public class HomePage : BasePage
    {
        

        public HomePage(IWebDriver driver) : base(driver)
        {
            
        }


        [FindsBy(How = How.XPath, Using = "//nav[@role='navigation']//a[contains(text(), 'News')]")]
        private IWebElement newsButton;
        

        [FindsBy(How = How.XPath, Using = "//div[@class='sign_in-container']//button[@class='sign_in-exit']")]
        public IWebElement laterButton;
        
        public void ClickOnNewsButton()
        {
            newsButton.Click();
        }
        public void ClickOnLaterButton()
        {
            laterButton.Click();
        }

        private IWebElement GetTabLink(Tabs tab)
        {
            return driver.FindElement(By.XPath($"//div[@id='orb-nav-links']//li[contains(@class, '{tab}')]/a"));
        }

        public void GoTo(Tabs tab) => GetTabLink(tab.ToString().ToLower()).Click();





       

        

    }
}
