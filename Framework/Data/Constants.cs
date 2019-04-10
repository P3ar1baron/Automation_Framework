using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Data
{
    public class Constants
    {
        public  enum Browsers
        {
            Chrome,IE
        }
        public string Path => ConfigurationManager.AppSettings["PathToScreenshotFolder"];

        public void Test(Browsers browserType)
        {

        }

        public void Test1()
        {
            Test(Browsers.Chrome);
        }

        public IWebDriver Driver
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
