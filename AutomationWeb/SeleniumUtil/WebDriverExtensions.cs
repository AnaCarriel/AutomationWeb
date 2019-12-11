using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AutomationWeb.SeleniumUtil
{
    public static class WebDriverExtensions
    {
        public static void LoadPage(this IWebDriver webDriver, TimeSpan timeWait, string url)
        {
            webDriver.Manage().Timeouts().PageLoad = timeWait;
            webDriver.Navigate().GoToUrl(url);
        }
        /// <summary>
        /// Manipula elementos html
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="by"></param>
        /// <returns></returns>
        public static string GetText(this IWebDriver webDriver, By by)
        {
            IWebElement webElement = webDriver.FindElement(by);
            return webElement.Text;
        }
    }
}
