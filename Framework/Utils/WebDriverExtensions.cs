using OpenQA.Selenium;
using System.Configuration;

namespace Framework.Utils
{
    public static class WebDriverExtensions
    {
        public static void TakeScreenshot(this IWebDriver driver, string pathToFile = @"C:\Users\Vlad\screen.png",
             ScreenshotImageFormat format = ScreenshotImageFormat.Png)
        {
            ((ITakesScreenshot)driver)
                .GetScreenshot()
                .SaveAsFile(pathToFile,format);

        }
    }
}
