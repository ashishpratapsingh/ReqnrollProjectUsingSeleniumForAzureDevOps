using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using ReqnrollProjectUsingSeleniumForAzureDevOps.DependencyInjection;
using ReqnrollProjectUsingSeleniumForAzureDevOps.DriverFactory.Interfaces;
using ReqnrollProjectUsingSeleniumForAzureDevOps.Pages.Interfaces;

namespace ReqnrollProjectUsingSeleniumForAzureDevOps.StepDefinitions
{
    [Binding]
    public class GoogleStepDefinitions
    {        
        private readonly IConfiguration _configuration;                
        private readonly IGoogleHomePage _googleHomePage;           

        public GoogleStepDefinitions() 
        { 
            this._configuration = StartUp.ResolveService<IConfiguration>();
            this._googleHomePage = StartUp.ResolveService<IGoogleHomePage>();            
        }

        [Given("I am on google home page")]
        public void GivenIAmOnGoogleHomePage()
        {
            string? appUrl = _configuration.GetSection("Application:Url").Value;
            _googleHomePage.NavigateToUrl(appUrl);
        }

        [When("I enter a search string and enter")]
        public void WhenIEnterASearchStringAndEnter()
        {
            _googleHomePage.searchText.SendKeys("restassured.net in c#");
            _googleHomePage.searchText.SendKeys(Keys.Enter);
        }

        [Then("google must display the search result")]
        public void ThenGoogleMustDisplayTheSearchResult()
        {
            
        }
    }
}
