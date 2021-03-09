using OpenQA.Selenium;
using SeleniumFramework.Base;

namespace POMImplementation.PageActions
{
    public class LoginWindowObjects
    {

        public static IWebElement UserNameTextField => DriverContext.Driver.FindElement(By.Name("UserName"));

        public static IWebElement PasswordTextField => DriverContext.Driver.FindElement(By.Name("Password"));

        public static IWebElement LoginButton => DriverContext.Driver.FindElement(By.XPath("//input[@Name='Login']"));

    }
}
