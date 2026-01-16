using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Tests
{
    public class BaseTest
    {
        private ChromeDriver driver;
        protected HomePage HomePage;

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }


        [TearDown]
        public void TearDown()
        {
            // NUnit1032: Ensure driver is disposed in [TearDown]
            driver?.Dispose();
        }
    }
}