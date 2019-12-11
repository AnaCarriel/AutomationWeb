using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;
using AutomationWeb.SeleniumUtil;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using NUnit.Framework;

namespace AutomationWeb
{
    public class BuyScreen
    {
        private IConfiguration _configuration;
        private Browser _browser;
        private IWebDriver _driver;

        public BuyScreen(IConfiguration configuration, Browser browser)
        {
            _configuration = configuration;
            _browser = browser;

            string pathDriver = null;
            if (browser == Browser.Firefox)
            {
                pathDriver = _configuration.GetSection("Selenium:CaminhoDriverFirefox").Value;
            }
            else if (browser == Browser.Chrome)
            {
                pathDriver = _configuration.GetSection("Selenium:CaminhoDriverChrome").Value;
            }
        }
        public void TimeLoadPage()
        {
            _driver.LoadPage(TimeSpan.FromSeconds(5), _configuration.GetConnectionString("Selenium:UrlAutomation"));
        }

        
        public IWebElement AddToCart()
        {
            _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/ul[1]/li[1]")).Click();
            return _driver.FindElement(By.Id("add_to_cart"));
        }
        public IWebElement Checkout()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            IWebElement element = wait.Until((d) => d.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/a")));
            return element;
        }
       
        
        public IWebElement Saveaccount()
        {
            return _driver.FindElement(By.Id("submitAccount"));
        }

        public IWebElement Total()
        {
            return _driver.FindElement(By.Id("total_price"));
        }
        public IWebElement Confirmation()
        {
            return _driver.FindElement(By.Id("cgv"));
        }
    }
}
