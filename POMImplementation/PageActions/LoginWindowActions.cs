using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumFramework.Base;
using SeleniumFramework.Extensions.WebElementExtensions;

namespace POMImplementation.PageActions
{
    public class LoginWindowActions: BasePage
    {

        public void ClickOnLoginButton()
        {
            LoginWindowObjects.LoginButton.ButtonClick();
        }

        public void EnterUserName(string userName)
        {
            LoginWindowObjects.UserNameTextField.EnterText(userName);
        }

        public void EnterPassword(string password)
        {
            LoginWindowObjects.PasswordTextField.EnterText(password);
        }

        public void VerifyLoginWindowLoaded()
        {
            Assert.IsTrue(DriverContext.Driver.Title.Contains("Execute Automation"));
        }

    }
}
