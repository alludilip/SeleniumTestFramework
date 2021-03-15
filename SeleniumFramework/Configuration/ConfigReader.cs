using SeleniumFramework.ConfigElement;
using System;
using static SeleniumFramework.Base.Browser;

namespace SeleniumFramework.Configuration
{
    public class ConfigReader
    {

        public static void SetFrameworkSettings()
        {
            Settings.AUT = TestConfiguration.Settings.TestSettings["staging"].AUT;
            //Settings.BuildName = TestConfiguration.Settings.TestSettings["staging"].BuildName;
            Settings.TestType = TestConfiguration.Settings.TestSettings["staging"].TestType;
            //Settings.IsReporting = TestConfiguration.Settings.TestSettings["staging"].IsReporting;
            Settings.LogPath = TestConfiguration.Settings.TestSettings["staging"].LogPath;
            Settings.BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), TestConfiguration.Settings.TestSettings["staging"].Browser);
            Settings.ExplicitWaitTimeout = TestConfiguration.Settings.TestSettings["staging"].ExplicitWaitTimeout;
            Settings.ImplicitWaitTimeout = TestConfiguration.Settings.TestSettings["staging"].ImplicitWaitTimeout;

        }




    }
}
