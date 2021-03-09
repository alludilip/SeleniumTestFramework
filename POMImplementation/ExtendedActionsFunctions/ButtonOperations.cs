using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using helpers = SeleniumExtras.WaitHelpers;
using System;

namespace POMImplementation.ExtendedActionsFunctions
{
    public static class ButtonOperations
    {

        // click onto a button/Checkbox/option
        public static void ButtonClick(this IWebElement element)
        {
           // BaseClass.wait.Until(helpers.ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }

    }
}
