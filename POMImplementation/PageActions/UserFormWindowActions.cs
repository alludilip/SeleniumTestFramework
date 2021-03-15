using SeleniumFramework.Base;
using SeleniumFramework.Extensions.WebElementExtensions;

namespace POMImplementation.PageActions
{
    public class UserFormWindowActions: BasePage
    {

        public void EnterInitial(string initial)
        {
            UserFormWindowObjects.InitialTextField.EnterText(initial);
        }

        public void EnterFirstName(string firstName)
        {
            UserFormWindowObjects.FirstNameTextField.EnterText(firstName);
        }

        public void EnterMiddleName(string middleName)
        {
            UserFormWindowObjects.MiddleNameTextField.EnterText(middleName);
        }

        public void SelectMaleRadioButton()
        {
            UserFormWindowObjects.MaleRadioButton.ButtonClick();
        }

        public void SelectEnglishCheckBox()
        {
            UserFormWindowObjects.EnglishCheckBox.ButtonClick();
        }

        public void SelectHindiCheckBox()
        {
            UserFormWindowObjects.HindiCheckBox.ButtonClick();
        }

        public void ClickonSaveButton()
        {
            UserFormWindowObjects.SaveButton.ButtonClick();
        }

        public void SelectDropDownValueusingValue(string value)
        {
            UserFormWindowObjects.TitleDropDown.SelectDropDownByValue(value);
        }

        public void SelectDropDownValueusingText(string text)
        {
            UserFormWindowObjects.TitleDropDown.SelectDropDownByText(text);
        }

        public void ClickOnLogoutButton()
        {
            UserFormWindowObjects.LogoutButton.ButtonClick();
        }
    }

}
