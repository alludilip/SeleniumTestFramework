using System.Configuration;

namespace SeleniumFramework.ConfigElement
{
    public class TestConfiguration : ConfigurationSection
    {
        private static TestConfiguration testConfig = (TestConfiguration)ConfigurationManager.GetSection("TestConfiguration");

        public static TestConfiguration Settings { get { return testConfig; } }

        [ConfigurationProperty("testSettings")]
        public FrameworkElementCollection TestSettings { get { return (FrameworkElementCollection)base["testSettings"]; } }



    }
}
