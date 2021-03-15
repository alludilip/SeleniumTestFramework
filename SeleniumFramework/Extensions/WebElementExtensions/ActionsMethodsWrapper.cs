using OpenQA.Selenium;
using SeleniumFramework.Base;
using helpers = SeleniumExtras.WaitHelpers;
namespace POMImplementation.Extensions.WebElementExtensions
{
    public static class AlertWindowOperations
    {

        // To Click on ok button in alert prompt window
        public static void AcceptInAlertWindow(this IWebDriver driver)
        {
            TestInitializeHook.WebDriverWait.Until(helpers.ExpectedConditions.AlertIsPresent());
            driver.SwitchTo().Alert().Accept();
        }

        // To Click on Cancel button in alert prompt window
        public static void CancelInAlertWindow(this IWebDriver driver)
        {
            TestInitializeHook.WebDriverWait.Until(helpers.ExpectedConditions.AlertIsPresent());
            driver.SwitchTo().Alert().Dismiss();
        }

        // To get the text data from alert window
        public static string GetTextFromAlertWindow(this IWebDriver driver)
        {
            TestInitializeHook.WebDriverWait.Until(helpers.ExpectedConditions.AlertIsPresent());
            return driver.SwitchTo().Alert().Text;
        }

        // To send authorization data to the alert window
        public static void SendCredentialsInAlertWindow(this IWebDriver driver, string userName, string password)
        {
            TestInitializeHook.WebDriverWait.Until(helpers.ExpectedConditions.AlertIsPresent());
            driver.SwitchTo().Alert().SetAuthenticationCredentials(userName, password);
        }

        // To enter text in the alert window
        public static void SendTextInAlertWindow(this IWebDriver driver, string textInput)
        {
            TestInitializeHook.WebDriverWait.Until(helpers.ExpectedConditions.AlertIsPresent());
            driver.SwitchTo().Alert().SendKeys(textInput);
        }

    }
}
