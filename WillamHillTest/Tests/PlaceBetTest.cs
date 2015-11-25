using NUnit.Framework;
using WillamHillTest.Pages;

namespace WillamHillTest.Tests
{
    [TestFixture]
    public class PlaceBetTest : TestBase
    {
        private LandingPage _landingPage;
        private HorseRacingPage _horseRacingPage;

        /// <summary>
        /// Test Steps: 
        /// 
        /// 1) Navigate to William Hill landing Page
        /// 2) click on Horsing Racing Tab link
        /// 3) select first candidate in "Next to Jump" row
        /// 4) and place win bet on first Runner
        /// 5) assert there is a 1 bet been placed in Bet Slip
        /// </summary>
        [Test]
        public void PlaceHorsingBet()
        {
            string url = BaseUrl + LandingPage.Path;
            _landingPage = new LandingPage(Driver,url);
            _landingPage.Load();
            _landingPage.MaxPageWindow();
            _horseRacingPage = _landingPage.ClickHorseRacing();
            _horseRacingPage.SelectHorse();
            _horseRacingPage.PlaceBet();
            var betCount = _horseRacingPage.GetBetCount(); 
            Assert.AreEqual(betCount,"1");
        }
    }
}
