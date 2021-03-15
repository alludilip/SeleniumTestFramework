using Microsoft.VisualStudio.TestTools.UnitTesting;
using POMImplementation.PageActions;
using SeleniumFramework.Helpers;
using System;

namespace TestExecutionProject
{
    [TestClass]
    public class LoginApplication: HookInitialize
    {

        // using Generics
        [TestMethod]

        public void LoginTestUsinGenerics()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;

            string fileName = Environment.CurrentDirectory.ToString() + @"\Data\Credentials.xlsx";
            ExcelHelpers.PopulateInCollection(fileName);
            
            CurrentPage = GetInstance<LoginWindowActions>();

            CurrentPage.As<LoginWindowActions>().EnterUserName(ExcelHelpers.ReadData(1, "UserName"));
            CurrentPage.As<LoginWindowActions>().EnterPassword(ExcelHelpers.ReadData(1, "Password"));
            CurrentPage.As<LoginWindowActions>().ClickOnLoginButton();

            CurrentPage = GetInstance<UserFormWindowActions>();
            CurrentPage.As<UserFormWindowActions>().ClickOnLogoutButton();

        }


    }
}