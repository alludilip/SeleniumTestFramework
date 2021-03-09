using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;

namespace POMImplementation
{
    public class BaseClass
    {

        public static IWebDriver Driver;
        public static WebDriverWait wait;
        public string baseURL =  ConfigurationManager.AppSettings["baseURL"];
        public string browserSelection = ConfigurationManager.AppSettings["browser"];
        public int  explicitWaitTimeout =Convert.ToInt32(ConfigurationManager.AppSettings["ExplicitWaitTimeout"]);
        public int implicitWaitTimeout = Convert.ToInt32(ConfigurationManager.AppSettings["ImplicitWaitTimeout"]);

        public void KillProcesses()
        {
            
            if (browserSelection == "chrome")
            {
                foreach (System.Diagnostics.Process proc in System.Diagnostics.Process.GetProcessesByName("chrome"))
                {
                    proc.Kill();
                }

                foreach (System.Diagnostics.Process proc in System.Diagnostics.Process.GetProcessesByName("chromedriver"))
                {
                    proc.Kill();
                }
            }

            if (browserSelection == "IE")
            {
                foreach (System.Diagnostics.Process proc in System.Diagnostics.Process.GetProcessesByName("IEDriverServer"))
                {
                    proc.Kill();
                }
                foreach (System.Diagnostics.Process proc in System.Diagnostics.Process.GetProcessesByName("iexplore"))
                {
                    proc.Kill();
                }
            }
        }

        [TestInitialize]
        public void Setup()
        {

            // KillProcesses();
            switch (browserSelection)
            {
                case "chrome":

                    if (Driver == null)
                    {
                        Driver = new ChromeDriver();
                    }
                    break;

                case "IE":

                    if (Driver == null)
                    {
                        Driver = new InternetExplorerDriver();
                    }

                    break;
            }

            // Implicit wait initiations for the driver
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitTimeout);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(implicitWaitTimeout);
            Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(implicitWaitTimeout);
            
            // Explicit timeout  initiation
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(explicitWaitTimeout));
            
            // Navigate to URL
            Driver.Navigate().GoToUrl(baseURL);
        }

        [TestCleanup]
        public void CleanUp()
        {
            // KillProcesses();
            //close and quit the browser
            Driver.Close();
            Driver.Quit();
            Driver = null;
        }





    }
}
