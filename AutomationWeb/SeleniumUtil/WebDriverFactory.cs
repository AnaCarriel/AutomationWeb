using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationWeb.SeleniumUtil
{
    public static class WebDriverFactory
    {
        /// <summary>
        /// Identifica qual o browser e seleciona o driver
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="pathDriver"></param>
        /// <returns></returns>
        public static IWebDriver CreateWebDriver(Browser browser, string pathDriver)
        {
            IWebDriver webDriver = null;

            switch (browser)
            {
                case Browser.Chrome:
                    webDriver = new ChromeDriver(pathDriver);
                    break;
                case Browser.Firefox:
                    webDriver = new FirefoxDriver(pathDriver);
                    break;
            }

            return webDriver;
        }
    }
}
