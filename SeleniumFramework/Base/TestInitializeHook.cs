using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using SeleniumFramework.Configuration;
using System;
using static SeleniumFramework.Base.Browser;

namespace SeleniumFramework.Base
{
    public class TestInitializeHook: Base
    {
        public readonly BrowserType Browser;
        public static WebDriverWait WebDriverWait;

        public TestInitializeHook(BrowserType browser)
        {
            Browser = browser;
        }

        public void InitializeSettings()
        {
            // set all configs for
            ConfigReader.SetFrameworkSettings();

          // LogHelpers.CreateLogFile();

            OpenBrowser(Browser);
        }

        // Open Browsers
        public void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Firefox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }

            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Int32.Parse(Settings.ImplicitWaitTimeout));
            DriverContext.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Int32.Parse(Settings.ImplicitWaitTimeout));

            // Explicit timeout  initiation
            WebDriverWait = new WebDriverWait(DriverContext.Driver, TimeSpan.FromSeconds(Int32.Parse(Settings.ExplicitWaitTimeout)));
        }

        public virtual void NavigateSite()
        {
            DriverContext.Browser.GotoUrl(Settings.AUT);
        }


    }

}
