using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace WillamHillTest.Webdriver
{
    /// <summary>
    /// webdriver factory 
    /// </summary>
    public class DriverFactory
    {
        /// <summary>
        /// private constructor
        /// </summary>
        private DriverFactory()
        {}

        public static IWebDriver GetDriver()
        {
            var driverType = ConfigurationManager.AppSettings["Driver"] ?? Browser.Firefox;
            if (driverType.ToLower().Equals(Browser.Firefox))
            {
                return new FirefoxDriver();
            }else if (driverType.ToLower().Equals(Browser.Chrome))
            {
                return new ChromeDriver();
            }
            else
            {
                throw new DriverServiceNotFoundException("The browser type is not supported");
            }
        }
    }

    
}
