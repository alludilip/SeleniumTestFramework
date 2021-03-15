using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumFramework.Base;

namespace SeleniumFramework.Extensions.WebElementExtensions
{
    public static class ActionsMethodsWrapper
    {

        public static Actions Actions = new Actions(DriverContext.Driver);

        // To drag and drop elements in window
        public static void DragAndDropAction(this IWebElement sourceLocation, IWebElement dropLocation)
        {
            Actions.DragAndDrop(sourceLocation, dropLocation).Build().Perform();
        }

        // To right click on an element
        public static void ContextClickAction(this IWebElement clickLocation)
        {
            Actions.ContextClick(clickLocation).Build().Perform();
        }

        // To double click on an element
        public static void DoubleClickAction(this IWebElement clickLocation)
        {
            Actions.DoubleClick(clickLocation).Build().Perform();
        }

        // To mover hover on an element
        public static void HoverOnElementAction(this IWebElement clickLocation)
        {
            Actions.MoveToElement(clickLocation).Build().Perform();
        }

    }
}
