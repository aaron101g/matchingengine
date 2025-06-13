using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchingEngine.Frontend.General
{
    public class FeGeneralMethods : SetUp
    {

        public void ClickElements(By locator, int indexPosition)
        {
            const int maxAttempts = 3;
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                try
                {
                    var element = FindElementsCustom(Driver, locator);
                    element[indexPosition].Click();

                    return;
                }
                catch (StaleElementReferenceException)
                {
                    attempts++;
                    Thread.Sleep(2500);
                }
                catch (ElementNotInteractableException)
                {
                    attempts++;
                    Thread.Sleep(2500);
                }
                catch (NoSuchElementException)
                {
                    attempts++;
                    Thread.Sleep(2500);
                }
            }

            throw new Exception($"ClickElement failed after {maxAttempts} attempts on locator: {locator}");
        }

        public IList<IWebElement> FindElementsCustom(IWebDriver driver, By locator)
        {
            const int maxAttempts = 3;
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                try
                {
                    IList<IWebElement> element = driver.FindElements(locator);

                    return element;
                }
                catch (StaleElementReferenceException)
                {
                    attempts++;
                    Thread.Sleep(2500);
                }
                catch (ElementNotInteractableException)
                {
                    attempts++;
                    Thread.Sleep(2500);
                }
                catch (NoSuchElementException)
                {
                    attempts++;
                    Thread.Sleep(2500);
                }
            }

            throw new Exception($"ClickElement failed after {maxAttempts} attempts on locator: {locator}");
        }
    }
}

