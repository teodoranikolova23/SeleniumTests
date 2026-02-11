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
            bool isTextPresent = TyposPage.TyposMessage.Text.Contains("Sometimes you'll see a typo");
            Assert.IsTrue(isTextPresent, "Expected typo message not found");
        }

        [Test]
        public void TyposPage_NavigateAndVerifyText()
        {
            HomePage.Typos.Click();
            string actualText = TyposPage.TyposMessage.Text;

            Assert.IsTrue(actualText.Contains("Sometimes you'll see a typo"),
                $"Expected text to contain 'Sometimes you'll see a typo', but was: {actualText}");

            //Assert.That(actualText, Does.Contain("Sometimes you'll see a typo"), $"Expected warning message to contain '{actualText}'.");
        }

        [Test]
        public void TyposPage_MessageShouldNotBeEmpty()
        {
            HomePage.Typos.Click();
            string content = TyposPage.TyposMessage.Text;

            Assert.IsNotEmpty(content, "The Typos message paragraph should not be empty.");
           
            //Assert.IsNotNull(content, "The Typos message paragraph should not be empty.");

            //Assert.That(string.IsNullOrWhiteSpace(content), Is.False);
        }
    }
}
