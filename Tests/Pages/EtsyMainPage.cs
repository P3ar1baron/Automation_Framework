using Framework.Pages;
using OpenQA.Selenium;

namespace Tests.Pages
{
    class EtsyMainPage : BasePage
    {
        public EtsyMainPage(IWebDriver driver) : base(driver)
        {
            searchArea = new SearchArea(driver);
        }

        public SearchArea searchArea;

    }
}
