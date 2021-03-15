using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumFramework.Base;
using SeleniumExtras.WaitHelpers;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace POMImplementation.PageActions
{
    public class LoginWindowObjects
    {

      //  public static IWebElement UserNameTextField => DriverContext.Driver.FindElement(By.Name("UserName"));

        public static IWebElement UserNameTextField => TestInitializeHook.WebDriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@Name='UserName']")));

        public static IWebElement PasswordTextField => DriverContext.Driver.FindElement(By.Name("Password"));

        public static IWebElement LoginButton => DriverContext.Driver.FindElement(By.XPath("//input[@Name='Login']"));
       
    }
}
