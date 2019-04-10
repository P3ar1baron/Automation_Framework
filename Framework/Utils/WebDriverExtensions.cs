using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utils
{
    static class WebDriverExtensions
    {
        static void TakeScreenshot(this IWebDriver driver)
        {
            ((ITakesScreenshot)driver)
                .GetScreenshot()
                .SaveAsFile("path to file", ScreenshotImageFormat.Png);
        }
    }
}
