using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ReqnrollProjectUsingSeleniumForAzureDevOps.DriverFactory.Interfaces;
using ReqnrollProjectUsingSeleniumForAzureDevOps.Pages.Interfaces;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollProjectUsingSeleniumForAzureDevOps.Pages
{
    public  class GoogleHomePage: IGoogleHomePage
    {
        private readonly IWebDriver _driver;

        public GoogleHomePage(IWebDriver driver) 
        { 
            this._driver = driver;           
            PageFactory.InitElements(_driver, this);
            _driver.Manage().Window.Maximize();
        }

        [FindsBy(How = How.Id, Using =("APjFqb"))]
        public IWebElement? searchText { get; set; }

        public void NavigateToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
    }
}