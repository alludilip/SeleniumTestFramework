using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFramework.Extensions.WebElementExtensions
{
    public static class SelectDropdownOperations
    {

        // To select dropdown using text of options
        public static void SelectDropDownByText(this IWebElement element, string text)
        {
            new SelectElement(element).SelectByText(text);
        }

        // To select dropdown using text of options
        public static void SelectDropDownByValue(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByValue(value);
        }

        // To select dropdown using ID of options
        public static void SelectDropDownByID(this IWebElement element, int index)
        {
            new SelectElement(element).SelectByIndex(index);
        }

        // To deselect all values 
        public static void DeSelectAll(this IWebElement element)
        {
            new SelectElement(element).DeselectAll();
        }

        // To deselect all values 
        public static void DeSelectByValue(this IWebElement element, string value)
        {
            new SelectElement(element).DeselectByValue(value);
        }

        // To verify if selected option is updated in select option
        public static void CheckSelectedOption(this IWebElement element, string value)
        {
            var selectedOption = GetTextFromElement(element);
            Assert.IsTrue(selectedOption == value, "Option is correctly selected");
        }

        // To read data from text field elements
        public static string GetTextFromElement(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        // To read data from dropdownlist
        public static string GetTextFromDropDown(this IWebElement element)
        {
            return new SelectElement(element).SelectedOption.ToString();
        }

        // To check if select fields are multiple select
        public static bool CheckIsMultiple(this IWebElement element)
        {
            return new SelectElement(element).IsMultiple;
        }

    }
}
