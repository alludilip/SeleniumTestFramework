using OpenQA.Selenium;
using SeleniumFramework.Base;
using System;
using System.Diagnostics;

namespace SeleniumFramework.Extensions
{
    public static class WebDriverExtensions
    {

        public static void WaitForPageLoaded(this IWebDriver webDriver)
        {
            webDriver.WaitForCondition(driver =>
            {
                string state = driver.ExecuteJS("return document.readyState").ToString();
                return state == "complete";
            }, 10);
        }

        public static void WaitForCondition<T>(this T obj, Func<T, bool> condition, int timeout)
        {
            Func<T, bool> execute =
                (arg) =>
                {
                    try
                    {
                        return condition(arg);
                    }
                    catch
                    {
                        return false;
                    }
                };

            var stopWatch = Stopwatch.StartNew();
            while (stopWatch.ElapsedMilliseconds < timeout)
            {
                if (execute(obj))
                {
                    break;
                }
            }

        }

        internal static object ExecuteJS(this IWebDriver driver, string script)
        {
            return ((IJavaScriptExecutor)DriverContext.Driver).ExecuteScript(script);
        }
    }
}
