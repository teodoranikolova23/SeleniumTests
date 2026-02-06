using OpenQA.Selenium.Chrome;
using SeleniumTests.Pages;
using SeleniumTests.Seleinum.Core;


namespace Tests
{
    public class BaseTest
    {
        private ChromeDriver driver;
        protected HomePage HomePage;
        protected TyposPage TyposPage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");

            IBrowser browser = new Browser(driver);

            HomePage = new HomePage(browser);
            TyposPage = new TyposPage(browser);
        }


        [TearDown]
        public void TearDown()
        {
            driver?.Dispose();
        }
    }
}