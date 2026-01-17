using OpenQA.Selenium.Chrome;
using SeleniumTests.Pages;
using Tests;

namespace SeleniumTests
{
    public class Tests : BaseTest
    {
        [Test]
        public void TyposPage_ShouldDisplayExpectedText()
        {
            HomePage.Typos.Click();
            TyposPage.TyposMessage.Text.Contains("Sometimes you'll see a typo");
        }
    }
}