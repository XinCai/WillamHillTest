using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace WillamHillTest.Pages
{
    public class HorseRacingPage : Page
    {
        private string Path = "horse-racinggrid/";
        public const int TimeOut = 20;
        private WebDriverWait _wait;

        [FindsBy(How = How.CssSelector, Using = "#racecardgrid > div > div.content-wrap > div > div:nth-child(1) > div > section:nth-child(1) > div.block-inner.block-betting.block-racecard.block-grid > table > tbody > tr > td:nth-child(2) > a")]
        private IWebElement _aFirstHorse;

        [FindsBy(How = How.CssSelector, Using = "[data-link-type='placeRaceBet']")]
        private IWebElement _aBetThirdOneWin;

        [FindsBy(How = How.Id, Using = "betslipBadge")] 
        private IWebElement _aBetslipBadge;

        public HorseRacingPage(IWebDriver driver, string url) : base(driver, url)
        {
            _wait = new WebDriverWait(driver, new TimeSpan(0, 0, TimeOut));
        }

        
        protected override void ExecuteLoad()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["Server.Base"] + Path);
        }

        protected override bool EvaluateLoadedStatus()
        {
            var isPageLoad = Driver.Url.Contains(Path);
            return isPageLoad;
        }

        public void SelectHorse()
        {
            _aFirstHorse.Click();           
        }

        public void PlaceBet()
        {
            _aBetThirdOneWin.Click();
        }

        public string GetBetCount()
        {
            return _aBetslipBadge.GetAttribute("data-count");
        }
    }
}
