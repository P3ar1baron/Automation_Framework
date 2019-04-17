using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace Framework.Driver
{
    public class CustomDriver
    {
        public static  IWebDriver Driver
        {
            get
            {
                if (ConfigurationManager.AppSettings["Browser"] == "Chrome")
                {
                    return new ChromeDriver();
                }

                else
                {
                    return new ChromeDriver();
                }
            }
        }
    }
}
