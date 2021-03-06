﻿using OpenQA.Selenium;
using System.Configuration;

namespace Framework.Utils
{
    public static class WebDriverExtensions
    {
        const string path = @"C:\Users\Vlad\screen.png";
        public static void TakeScreenshot(this IWebDriver driver, string pathToFile = path,
             ScreenshotImageFormat format = ScreenshotImageFormat.Png)
        {
            ((ITakesScreenshot)driver)
                .GetScreenshot()
                .SaveAsFile(pathToFile,format);

        }

        public static void ExecuteJavascript(this IWebDriver driver, string jsScript, params object[] args)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript(jsScript, args);
        }
    }
}

