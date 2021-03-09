using System.Configuration;

namespace SeleniumFramework.ConfigElement
{
    public class FrameworkElement : ConfigurationElement
    {

        [ConfigurationProperty("name", IsRequired = true)]
        public string Name { get { return (string)base["name"]; } }

        [ConfigurationProperty("aut", IsRequired = true)]
        public string AUT { get { return (string)base["aut"]; } }

        [ConfigurationProperty("browser", IsRequired = true)]
        public string Browser { get { return (string)base["browser"]; } }

        [ConfigurationProperty("testType", IsRequired = true)]
        public string TestType { get { return (string)base["testType"]; } }

        [ConfigurationProperty("isLog", IsRequired = true)]
        public string IsLog { get { return (string)base["isLog"]; } }

        [ConfigurationProperty("logPath", IsRequired = true)]
        public string Logpath { get { return (string)base["logPath"]; } }





    }
}
