using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using ReqnrollProjectUsingSeleniumForAzureDevOps.DependencyInjection;
using ReqnrollProjectUsingSeleniumForAzureDevOps.DriverFactory.Interfaces;
using ReqnrollProjectUsingSeleniumForAzureDevOps.Pages.Interfaces;
using System.Runtime.CompilerServices;

namespace ReqnrollProjectUsingSeleniumForAzureDevOps.Hooks
{
    [Binding]
    public sealed class GoogleHooks
    {        
        [BeforeTestRun]
        public static void BeforeTestRun() 
        {            
            StartUp.Initialize();           
        }
    }
}