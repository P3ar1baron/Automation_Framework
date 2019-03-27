
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Tests.Pages;
using Framework.Utils;

namespace Tests
{
    public class EtsyTests
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.etsy.com/");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestSearch()
        {
            EtsyMainPage etsyMainPage = new EtsyMainPage(driver);
            etsyMainPage.searchArea.searchField.SetText("");
        }
    }
}
