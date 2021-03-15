using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumFramework.Base;
using static SeleniumFramework.Base.Browser;

namespace TestExecutionProject
{
    public class HookInitialize : TestInitializeHook
    {

        public HookInitialize(): base(BrowserType.Chrome)
        {
            InitializeSettings();
            NavigateSite();
        }

        [TestCleanup]
        public void CleanUp()
        {
            // KillProcesses();
            //close and quit the browser
            DriverContext.Driver.Close();
            DriverContext.Driver.Quit();
            DriverContext.Driver = null;
        }

    }
}
