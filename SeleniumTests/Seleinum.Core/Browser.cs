using AngleSharp.Dom;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumTests.Seleinum.Core
{
    public class Browser : IBrowser
    {
        private ChromeDriver _driver;

        public Browser()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        public IElement CreateElement(By locator, string elementName)
        {
            return new SeleniumElement(_driver, locator, elementName);
        }

        public INavigation Navigate()
        {
            return _driver.Navigate();
        }

        public void GoToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void Maximize()
        {
            _driver.Manage().Window.Maximize();
        }

        public void Dispose()
        {
            _driver?.Quit();
            _driver?.Dispose();
        }
    }
}
