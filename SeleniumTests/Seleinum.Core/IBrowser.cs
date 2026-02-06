using OpenQA.Selenium;
using System;

namespace SeleniumTests.Seleinum.Core
{
    public interface IBrowser : IDisposable
    {
        IElement CreateElement(By locator, string elementName);
        INavigation Navigate();
        void GoToUrl(string url);
        void Maximize();
    }
}
