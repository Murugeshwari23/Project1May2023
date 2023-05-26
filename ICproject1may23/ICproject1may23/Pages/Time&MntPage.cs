
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICproject1may23.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ICproject1may23.Pages
{
    public class Time_MntPage : Commondriver
    {
       
        public void CreateTimerecord(IWebDriver driver)
        {
            IWebElement CreateNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            CreateNew.Click();
            Thread.Sleep(1000);

            IWebElement typecode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typecode.Click();

            Thread.Sleep(2000);
            IWebElement time = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            time.Click();
            Thread.Sleep(3000);

            IWebElement fieldcode = driver.FindElement(By.Id("Code"));
            fieldcode.SendKeys("Project1");

            IWebElement fieldDescription = driver.FindElement(By.Id("Description"));
            fieldDescription.SendKeys("First Project");
            Thread.Sleep(2000);

            IWebElement priceunit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceunit.SendKeys("60");
            Thread.Sleep(3000);

            IWebElement Savebutton = driver.FindElement(By.Id("SaveButton"));
            Savebutton.Click();
            Thread.Sleep(2000);

            IWebElement LastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            LastPage.Click();
            Thread.Sleep(2000);

            //check if record created
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(3000);
            if (newCode.Text == "Project1")
            {
                Assert.Pass("Record Project1 created successfully.");
            }
            else
            {
                Assert.Fail("Time record Project1 has not been created successfully.");
            }

        }

        public void EditTimerecord(IWebDriver driver)
        {
            //Edit the record
            IWebElement Editbutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            Editbutton.Click();
            Thread.Sleep(2000);

            IWebElement time1 = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            time1.Click();
            Thread.Sleep(2000);

            //edit the codename
            IWebElement fieldcode1 = driver.FindElement(By.Id("Code"));
            fieldcode1.Clear();
            fieldcode1.SendKeys("Project2");


            //edit the description name
            IWebElement fieldDescription1 = driver.FindElement(By.Id("Description"));
            fieldDescription1.Clear();
            fieldDescription1.SendKeys("Second Project");

            // WaitTime.WaitToBeClickable(driver, "XPath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]", 5 );

            IWebElement editPriceOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            editPriceOverlap.Click();

            IWebElement editPrice = driver.FindElement(By.Id("Price"));
            editPrice.Clear();
            Thread.Sleep(3000);
            editPriceOverlap.SendKeys("800");

            Thread.Sleep(3000);


            //save the edited record
            IWebElement Savebutton1 = driver.FindElement(By.Id("SaveButton"));
            Savebutton1.Click();
            Thread.Sleep(3000);

            //navigate to last page.
            IWebElement LastPage1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            LastPage1.Click();
            Thread.Sleep(2000);

            // check if recored edited 
            IWebElement newCode1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(2000);

            if (newCode1.Text == "Project2")
            {
                Console.WriteLine("Project1 Record Edited to Project2 successfully.");
            }
            else
            {
                Console.WriteLine("Time record has not been edited successfully.");
            }
        }
        public void DeleteTimerecord(IWebDriver driver)
        {
            //delete the record
            IWebElement Deletebutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            Deletebutton.Click();
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

            IWebElement lastpage2 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastpage2.Click();
            Thread.Sleep(2000);

            //check if record deleted
            IWebElement lastrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (lastrecord.Text != "Project2")
            {
                Console.WriteLine("Project2 deleted successfully");
            }
            else
            {
                Console.WriteLine("Project2 has not been deleted successfully");
            }

        }
    }
}
