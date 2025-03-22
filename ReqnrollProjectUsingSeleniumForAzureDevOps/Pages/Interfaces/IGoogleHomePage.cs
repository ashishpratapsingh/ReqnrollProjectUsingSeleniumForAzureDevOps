using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollProjectUsingSeleniumForAzureDevOps.Pages.Interfaces
{
    public  interface IGoogleHomePage
    {
        IWebElement? searchText { get; set; }
        public void NavigateToUrl(string url);
    }
}