
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Tests.Pages;
using Framework.Utils;
using System.Threading;
using System.Collections.Generic;

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
            var searchText = "Men's Martin Boots";
            EtsyMainPage etsyMainPage = new EtsyMainPage(driver);
            etsyMainPage.searchArea.searchField.SetText(searchText);
            etsyMainPage.searchArea.searchButton.Click();

            EtsySearchPage etsySearchPage = new EtsySearchPage(driver);

            var texts = etsySearchPage.searchResultsTextItems;

            foreach (var textItem in texts)
            {
                Console.WriteLine(textItem.Text);
                Assert.True(textItem.Text.Contains(searchText));
            }

            driver.TakeScreenshot();

        }
    }
}
