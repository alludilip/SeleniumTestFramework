using OpenQA.Selenium;

namespace SeleniumFramework.Base
{
    public static class DriverContext
    {

        private static IWebDriver WebDriver;

        public static IWebDriver Driver
        {
            get
            {
                return WebDriver;
            }
            set
            {
                WebDriver = value;
            }
        }

        public static Browser Browser { get; set; }


    }
}
