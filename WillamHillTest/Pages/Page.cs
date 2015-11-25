using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace WillamHillTest.Pages
{
    /// <summary>
    /// Implement page object model 
    /// </summary>
    public abstract class Page : LoadableComponent<Page>
    {
        protected abstract override void ExecuteLoad();

        protected abstract override bool EvaluateLoadedStatus();
        
        private readonly IWebDriver _driver;
        private string _url; 

        protected Page(IWebDriver driver, string url)
        {
            _driver = driver;
            _url = url;
            PageFactory.InitElements(driver,this);
        }

        public IWebDriver Driver
        {
            get { return _driver; }
        }

        public string Url
        {
            get { return _url; }
        }

        /// <summary>
        /// max the page after page load 
        /// </summary>
        public void MaxPageWindow()
        {
            _driver.Manage().Window.Maximize();
        }
    }
}
