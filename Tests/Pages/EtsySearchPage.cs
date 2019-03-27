using Framework.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace Tests.Pages
{
    class EtsySearchPage : BasePage
    {
        public EtsySearchPage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//*[contains(@class, 'v2-listing-card__info') and not (contains(@class, 'flex'))]")]
        public IList<IWebElement> searchResultsTextItems;
    }
}
