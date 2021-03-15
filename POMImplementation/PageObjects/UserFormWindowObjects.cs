using OpenQA.Selenium;
using SeleniumFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMImplementation.PageActions
{
    public class UserFormWindowObjects
    {
        public static IWebElement TitleDropDown => DriverContext.Driver.FindElement(By.Name("TitleId"));

        public static IWebElement InitialTextField => DriverContext.Driver.FindElement(By.Name("Initial"));

        public static IWebElement FirstNameTextField => DriverContext.Driver.FindElement(By.Name("FirstName"));

        public static IWebElement MiddleNameTextField => DriverContext.Driver.FindElement(By.Name("MiddleName"));

        public static IWebElement MaleRadioButton => DriverContext.Driver.FindElement(By.Name("Male"));

        public static IWebElement FemaleRadioButton => DriverContext.Driver.FindElement(By.Name("Female"));

        public static IWebElement EnglishCheckBox => DriverContext.Driver.FindElement(By.Name("english"));

        public static IWebElement HindiCheckBox => DriverContext.Driver.FindElement(By.Name("Hindi"));

        public static IWebElement SaveButton => DriverContext.Driver.FindElement(By.XPath("//input[@Name='Save']"));

        public static IWebElement LogoutButton => DriverContext.Driver.FindElement(By.XPath("//span['Logout']"));

    }
}
