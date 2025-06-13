using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchingEngine
{
    public class SetUp
    {
        public IWebDriver Driver { get; set; }
        public string url { get; set; } = "https://www.matchingengine.com/";


        public void InitializeFE(string browserType = "Chrome")
        {
            BrowserSelect(browserType);

        }

        public void BrowserSelect(string browser)
        {
            if (browser == "Chrome")
            {
                var chromeOptions = new ChromeOptions();
                //chromeOptions.AddArgument("--headless");
                chromeOptions.AddArgument("--disable-gpu");
                chromeOptions.AddArgument("--no-sandbox");
                chromeOptions.AddArgument("--disable-dev-shm-usage");
                chromeOptions.AddArgument("--disable-extensions");
                chromeOptions.AddArgument("--disable-infobars");
                chromeOptions.AddArgument("--disable-popup-blocking");
                chromeOptions.AddArgument("--disable-plugins-discovery");
                chromeOptions.AddArgument("--disable-search-engine-choice-screen");
                chromeOptions.AddArgument("--disable-background-timer-throttling");
                chromeOptions.AddArgument("--disable-backgrounding-occluded-windows");
                chromeOptions.AddArgument("--disable-breakpad");
                chromeOptions.AddArgument("--disable-sync");
                chromeOptions.AddArgument("--disable-translate");
                chromeOptions.AddArgument("--window-size=1920,1080");
               
                Driver = new ChromeDriver(chromeOptions);
                Driver.Manage().Window.Maximize();

            }
            else if (browser == "Edge")
            {
                Driver = new EdgeDriver();
                // Not needed but available if required
            }
            else if (browser == "FireFox")
            {
                Driver = new FirefoxDriver();
                // Not needed but available if required
            }

        }

        public void JumpToURL(string urlToNavigateTo)
        {
            Driver.Navigate().GoToUrl(urlToNavigateTo);
        }
    }


}
