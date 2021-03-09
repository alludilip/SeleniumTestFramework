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
            Settings.TestType = TestConfiguration.Settings.TestSettings["staging"].IsLog;
            //Settings.IsReporting = TestConfiguration.Settings.TestSettings["staging"].IsReporting;
            Settings.LogPath = TestConfiguration.Settings.TestSettings["staging"].Logpath;
            Settings.BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), TestConfiguration.Settings.TestSettings["staging"].Browser);


        }




    }
}
