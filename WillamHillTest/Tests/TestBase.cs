using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using WillamHillTest.Webdriver;

namespace WillamHillTest.Tests
{
    /// <summary>
    /// Base Test Case , all test cases should derived from it 
    /// </summary>
    [TestFixture]
    public class TestBase
    {
        public IWebDriver Driver;
        public string BaseUrl;

        [TestFixtureSetUp]
        public void Setup()
        {
            BaseUrl = ConfigurationManager.AppSettings["Server.Base"];
            if (Driver == null)
            {
                Driver = DriverFactory.GetDriver();    
            }
            
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Status == TestStatus.Failed)
            {
                PerformCleanUp();
            }
            Driver.Quit();
        }

        private void PerformCleanUp()
        {           
            Driver.Manage().Cookies.DeleteAllCookies();
        }
    }
}
