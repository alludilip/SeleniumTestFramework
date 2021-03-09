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






    }
}
