using AngleSharp.Dom;
using OpenQA.Selenium;
using SeleniumTests.Seleinum.Core;
using IElement = SeleniumTests.Seleinum.Core.IElement;

namespace SeleniumTests.Pages
{
    public class HomePage
    {
        private readonly IBrowser Browser;

        public HomePage(IBrowser browser)
        {
            Browser = browser;
        }

        public IElement Typos => Browser.CreateElement(By.XPath("//li/a[contains(@href, 'typos')]"), "Typos");
    }
}