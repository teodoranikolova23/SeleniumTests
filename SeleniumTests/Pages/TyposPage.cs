using OpenQA.Selenium;
using SeleniumTests.Seleinum.Core;
using IElement = SeleniumTests.Seleinum.Core.IElement;

namespace SeleniumTests.Pages
{
    public class TyposPage
    {
        private readonly IBrowser Browser;
        public TyposPage(IBrowser browser)
        {
            Browser = browser;
        }

        public IElement TyposMessage => Browser.CreateElement(
            By.XPath("//div[@class='example']/p[contains(text(), 'Sometimes')]"),
            "TyposMessage"
        );
    }
}