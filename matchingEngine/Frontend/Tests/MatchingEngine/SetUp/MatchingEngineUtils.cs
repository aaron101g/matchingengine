using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchingEngine.Frontend.Tests.MatchingEngine.SetUp
{
    public class MatchingEngineUtils
    {
        public string url { get; set; } = "https://www.matchingengine.com/";

        // Nav
        public By moduleNav { get; set; } = By.XPath("//*[@id=\"navMenu\"]/div[1]/div[1]/a");
        public By repertoireManagementModuleNav { get; set; } = By.XPath("//*[@id=\"navMenu\"]/div[1]/div[1]/div/a[2]");
        public By productsSupportedNav { get; set; } = By.XPath("/html/body/div/div/div/section/div[6]/div/div/div/div[2]/div/div[1]/ul/li[2]/a/span");

        // Headings
        public By additionalFeaturesHeading { get; set; } = By.XPath("/html/body/div/div/div/section/div[6]/div/div/div/h2");
        public By productsSupportedHeading { get; set; } = By.XPath("//*[@id=\"1661350017393-4859bb9f-5341c79e-be34\"]/div[2]/div/div[2]/div/div/h3");
        
        // Assertions
        public string productsSupportedAssertionText { get; set; } = "There are several types of Product Supported:";

    }
}
