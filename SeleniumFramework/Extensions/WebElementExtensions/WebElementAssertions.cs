using OpenQA.Selenium;
using System;

namespace POMImplementation.ExtendedActionsFunctions
{
    public static class WebElementAssertions
    {

        public static void AssertElementPresent(this IWebElement webElement)
        {
            if(webElement.Displayed == true)
            {
                throw new Exception("Element not present in the window Exception");
            }
        }

        public static void AssertElementEnabled(this IWebElement webElement)
        {
            if (webElement.Enabled == true)
            {
                throw new Exception("Element not enabled");
            }
        }


    }
}
