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

        public void ClickElement(By locator)
        {
            const int maxAttempts = 3;
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                try
                {
                    var element = FindElementCustom(Driver, locator);
                    element.Click();

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

        public IWebElement FindElementCustom(IWebDriver driver, By locator)
        {
            const int maxAttempts = 3;
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                try
                {
                    var element = driver.FindElement(locator);

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

        public void ScrollToElement(By element)
        {
            IWebElement elementToScrollTo = Driver.FindElement(element);
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView();", elementToScrollTo);
        }
    }
}

