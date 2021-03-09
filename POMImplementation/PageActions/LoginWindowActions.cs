using Microsoft.VisualStudio.TestTools.UnitTesting;
using POMImplementation.ExtendedActionsFunctions;
using SeleniumFramework.Base;

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
            Assert.IsTrue(BaseClass.Driver.Title.Contains("Execute Automation"));
        }

    }
}
