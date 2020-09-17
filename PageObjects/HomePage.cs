using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Support.UI;
using System;
using UnitTestProject2.PageObjects;
using SeleniumExtras.PageObjects;


namespace UnitTestProject2
{
    public class HomePage : BasePage
    {
        
        public HomePage(IWebDriver driver) : base(driver)
        {
            
        }


        [FindsBy(How = How.XPath, Using = "//nav[@role='navigation']//a[contains(text(), 'News')]")]
        private IWebElement newsButton;
        

        [FindsBy(How = How.XPath, Using = "//div[@class='sign_in-container']//button[@class='sign_in-exit']")]
        private IWebElement laterButton;
        
        public void ClickOnNewsButton()
        {
            newsButton.Click();
        }
        public void ClickOnLaterButton()
        {
            laterButton.Click();
        }

        





       

        

    }
}
