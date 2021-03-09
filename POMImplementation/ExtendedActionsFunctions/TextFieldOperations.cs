using OpenQA.Selenium;
using helpers = SeleniumExtras.WaitHelpers;


namespace POMImplementation.ExtendedActionsFunctions
{
    public static class TextFieldOperations
    {

        // To enter text into a textfield
        public static void ClearAndEnterText(this IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        // To enter text into a textfield
        public static void EnterText(this IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        // To enter text into a textfield
        public static void ClearText(this IWebElement element)
        {
            if(element.GetAttribute("value")!= null)
            {
                element.Clear();
            }
        }

    }
}
