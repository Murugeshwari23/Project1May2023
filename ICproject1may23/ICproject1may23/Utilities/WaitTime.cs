using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace ICproject1may23.Utilities
{
    public class WaitTime
    {
        public static void WaitToBeClickable(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            var WaitTime = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            WaitTime.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((By.XPath("locatorValue"))));

  
        }


    }
}
