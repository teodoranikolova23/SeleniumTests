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

        [Test]
        public void TyposPage_NavigateAndVerifyText()
        {
            HomePage.Typos.Click();
            string actualText = TyposPage.TyposMessage.Text;

            Assert.IsTrue(actualText.Contains("Sometimes you'll see a typo"),
                $"Expected text to contain 'Sometimes you'll see a typo', but was: {actualText}");
        }

        [Test]
        public void TyposPage_MessageShouldNotBeEmpty()
        {
            HomePage.Typos.Click();
            string content = TyposPage.TyposMessage.Text;

            Assert.IsNotEmpty(content, "The Typos message paragraph should not be empty.");
        }
    }
}
