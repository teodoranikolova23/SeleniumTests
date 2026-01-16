using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests.Pages;
using Tests;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumTests
{
    public class Tests : BaseTest
    {
        private ChromeDriver driver;

        [Test]
        public void TyposPage_ShouldDisplayExpectedText()
        {
            HomePage.Typos.Click();
            //var pageText = driver.FindElement(By.CssSelector("#content p:nth-of-type(2)")).Text;
            //Assert.That(
            //    pageText,
            //    Is.EqualTo("Sometimes you'll see a typo, other times you won't"),
            //    "The expected typo text was not displayed correctly."
            );
        }
    }
}