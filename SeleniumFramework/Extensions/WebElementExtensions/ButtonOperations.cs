using OpenQA.Selenium;
using helpers = SeleniumExtras.WaitHelpers;
using SeleniumFramework.Base;

namespace SeleniumFramework.Extensions.WebElementExtensions
{
    public static class ButtonOperations
    {

        // click onto a button/Checkbox/option
        public static void ButtonClick(this IWebElement element)
        {
            TestInitializeHook.WebDriverWait.Until(helpers.ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }

    }
}
