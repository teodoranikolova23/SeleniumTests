using OpenQA.Selenium.Chrome;
using SeleniumTests.Pages;
using SeleniumTests.Seleinum.Core;
using Tests;

namespace SeleniumTests
{
    public class Tests : BaseTest
    {
        protected HomePage HomePage => new(Browser);
        protected TyposPage TyposPage => new(Browser);

        [Test]
        public void TyposPage_ShouldDisplayExpectedText()
        {
            HomePage.Typos.Click();
            TyposPage.TyposMessage.Text.Contains("Sometimes you'll see a typo");
        }
    }
}