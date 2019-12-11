using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;
using AutomationWeb.SeleniumUtil;
using OpenQA.Selenium;
using NUnit.Framework;


namespace AutomationWeb
{
    class NewUser
    {
        private IWebDriver _driver;

        public NewUser(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement emailNewUser()
        {
            return _driver.FindElement(By.Id("email_create"));
        }
        public IWebElement createAnAccount()
        {
            return _driver.FindElement(By.Id("SubmitCreate"));
        }
        public IWebElement title()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            IWebElement element = wait.Until(((d) => d.FindElement(By.Name("id_gender"))));
            return element;
        }
        public IWebElement firstName()
        {
            return _driver.FindElement(By.Id("customer_firstname"));
        }
        public IWebElement lastName()
        {
            return _driver.FindElement(By.Id("customer_lastname"));
        }
        public IWebElement password()
        {
            return _driver.FindElement(By.Id("passwd"));
        }
        public IWebElement days()
        {
            return _driver.FindElement(By.Id("days"));
        }
        public IWebElement month()
        {
            return _driver.FindElement(By.Id("months"));
        }
        public IWebElement year()
        {
            return _driver.FindElement(By.Id("years"));
        }
        public IWebElement address()
        {
            return _driver.FindElement(By.Id("address1"));
        }
        public IWebElement city()
        {
            return _driver.FindElement(By.Id("city"));
        }
        public IWebElement state()
        {
            return _driver.FindElement(By.Id("id_state"));
        }
        public IWebElement postCode()
        {
            return _driver.FindElement(By.Id("postcode"));
        }
        public IWebElement country()
        {
            return _driver.FindElement(By.Id("id_country"));
        }
        public IWebElement mobilePhone()
        {
            return _driver.FindElement(By.Id("phone_mobile"));
        }
        public IWebElement submitAccount()
        {
            return _driver.FindElement(By.Id("submitAccount"));
        }
        public void ValidAdress()
        {
            var valid = WebDriverExtensions.GetText(_driver, By.Id("address1"));
            Assert.AreEqual(_driver.FindElement(By.Id("id_address_delivery")), valid);
        }
    }
}
