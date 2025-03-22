using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using ReqnrollProjectUsingSeleniumForAzureDevOps.DriverFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollProjectUsingSeleniumForAzureDevOps.DriverFactory
{
    public  class WebDriverFactory : IWebDriverFactory
    {        
        public IWebDriver getRequiredDriver<T>() where T : WebDriver
        {
            IWebDriver? driver;

            switch (typeof(T).Name)
            {
                case "ChromeDriver":
                    driver = new ChromeDriver();
                    break;
                case "FirefoxDriver":
                    driver = new FirefoxDriver();
                    break;
                case "InternetExplorerDriver":
                    driver = new InternetExplorerDriver();
                    break;
                case "SafariDriver":
                    driver = new SafariDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

            return driver;
        }
    }
}