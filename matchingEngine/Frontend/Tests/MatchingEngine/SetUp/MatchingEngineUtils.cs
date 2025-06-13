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

        public By moduleNav { get; set; } = By.XPath("//*[@id=\"navMenu\"]/div[1]/div[1]/a");
        public By repertoireManagementModuleNav { get; set; } = By.XPath("//*[@id=\"navMenu\"]/div[1]/div[1]/div/a[2]");

        public By additionalFeaturesHeading { get; set; } = By.XPath("/html/body/div/div/div/section/div[6]/div/div/div/h2");
        


    }
}
