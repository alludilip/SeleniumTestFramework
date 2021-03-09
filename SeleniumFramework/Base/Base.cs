using OpenQA.Selenium;

namespace SeleniumFramework.Base
{
    public class Base
    {
        public BasePage CurrentPage { get; set; }

        private IWebDriver driver { get; set; }
        
        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                driver = DriverContext.Driver
            };
            return pageInstance;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
