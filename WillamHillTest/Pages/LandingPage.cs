using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace WillamHillTest.Pages
{
    public class LandingPage : Page
    {
        public const string Path = "";
        private WebDriverWait _wait;
        private const int TimeOut = 20;

        [FindsBy(How = How.CssSelector, Using = "#local-nav > div > ul:nth-child(1) > li:nth-child(2) > a")] 
        private readonly IWebElement _aHorsRacingLink;

        public LandingPage(IWebDriver driver, string url) : base(driver, url)
        {
            _wait = new WebDriverWait(driver, new TimeSpan(0,0,TimeOut));
        }

        protected override void ExecuteLoad()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["Server.Base"] + Path);
        }

        protected override bool EvaluateLoadedStatus()
        {
            var isPageLoad = Driver.Url.Contains("www.williamhill.com.au");
            return isPageLoad;
        }

        public HorseRacingPage ClickHorseRacing()
        {
            _aHorsRacingLink.Click();
            return new HorseRacingPage(Driver, Url);
        }
    }
}
