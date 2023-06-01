using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ICproject1may23.Pages
{
    public class HomePage
    {
     public void GoToTMPage(IWebDriver driver)
     {
     // Create new record
        IWebElement Administrationtab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        Administrationtab.Click();
        Thread.Sleep(3000);

        IWebElement TimeMatbutton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        TimeMatbutton.Click();
        Thread.Sleep(4000);
        }

        public void GoToEmployeePage (IWebDriver driver)
        {
            IWebElement Administrationtab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administrationtab.Click();
            Thread.Sleep(2000);

            IWebElement Employeesbutton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Employeesbutton.Click();
            Thread.Sleep(2000);

        }

}
}
