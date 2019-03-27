using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Utils
{
    static class WebElementExtensions
    {
        public static void SetText(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public static void SetTextIntoDropdown(this IWebElement element, string text)
        {
            new SelectElement(element).SelectByText(text);
        }


    }
}
