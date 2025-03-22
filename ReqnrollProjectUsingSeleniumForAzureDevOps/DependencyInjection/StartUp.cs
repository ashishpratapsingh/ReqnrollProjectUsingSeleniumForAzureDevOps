using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ReqnrollProjectUsingSeleniumForAzureDevOps.DriverFactory;
using ReqnrollProjectUsingSeleniumForAzureDevOps.DriverFactory.Interfaces;
using ReqnrollProjectUsingSeleniumForAzureDevOps.Pages;
using ReqnrollProjectUsingSeleniumForAzureDevOps.Pages.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollProjectUsingSeleniumForAzureDevOps.DependencyInjection
{
    public static class StartUp
    {
        private static IServiceProvider? _serviceProvider;

        public static void Initialize()
        {
            var configuration = new ConfigurationBuilder()
            .AddJsonFile($"Configuration/appsettings.json", optional: false, reloadOnChange: true).Build();

            
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IConfiguration>(_ => configuration);
            serviceCollection.AddSingleton<IWebDriverFactory, WebDriverFactory>();
            serviceCollection.AddTransient<IWebDriver>(_ =>
            {
                var driverfactory = ResolveService<IWebDriverFactory>();
                return driverfactory.getRequiredDriver<ChromeDriver>();
            });

            serviceCollection.AddTransient<IGoogleHomePage, GoogleHomePage>();

            _serviceProvider = serviceCollection.BuildServiceProvider();
                       
        }

        public static T ResolveService<T>() where T : class
        {            
            return _serviceProvider.GetRequiredService<T>();
        }
    }
} 