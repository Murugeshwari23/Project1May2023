
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
    public class Time_MntPage : CommonDriver
    {

        public void CreateTimerecord(IWebDriver driver)
        {
            IWebElement CreateNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            CreateNew.Click();
            Thread.Sleep(1000);

            IWebElement typecode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typecode.Click();

            Thread.Sleep(2000);
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            IWebElement Code = driver.FindElement(By.Id("Code"));
            Code.SendKeys("Project1");

            IWebElement fieldDescription = driver.FindElement(By.Id("Description"));
            fieldDescription.SendKeys("Project1");

            IWebElement priceunit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceunit.SendKeys("60");

            IWebElement Savebutton = driver.FindElement(By.Id("SaveButton"));
            Savebutton.Click();
            Thread.Sleep(2000);

            IWebElement LastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            LastPage.Click();
            Thread.Sleep(2000);

            /*IWebElement LastElement = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

                Assert.Fail("New record has not been found.");*/
        }

        public string GetCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;

        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;

        }
        public string GetPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }

        public void EditTimerecord(IWebDriver driver)
        {
            //Edit the record
            Thread.Sleep(2000);
            IWebElement LastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            LastPage.Click();
            Thread.Sleep(2000);

            IWebElement editbutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editbutton.Click();
            Thread.Sleep(2000);

            IWebElement edittimeOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            edittimeOption.Click();
            Thread.Sleep(2000);

            //edit the codename
            IWebElement editdcode = driver.FindElement(By.Id("Code"));
            editdcode.Clear();
            editdcode.SendKeys("Project2");
            Thread.Sleep(2000);

            //edit the description name
            IWebElement editDescription = driver.FindElement(By.Id("Description"));
            editDescription.Clear();
            editDescription.SendKeys("Second Project");
            Thread.Sleep(2000);

            IWebElement editPriceOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
             editPriceOverlap.Click();

            IWebElement editPrice = driver.FindElement(By.Id("Price"));
            editPrice.Clear();
            Thread.Sleep(1000);
            editPriceOverlap.SendKeys("500");

            Thread.Sleep(2000);


            //save the edited record
            IWebElement Savebutton = driver.FindElement(By.Id("SaveButton"));
            Savebutton.Click();
            Thread.Sleep(3000);

            //navigate to last page.
            IWebElement goToEditLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToEditLastPageButton.Click();
            Thread.Sleep(2000);

            // check if recored edited 
            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(2000);
            Assert.That(editedCode.Text == "Project2", "Actual Code and expected code do not match.");
        }

        public string GeteditedCode(IWebDriver driver)
        {
            IWebElement createdcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return createdcode.Text;

        }


        public void DeleteTimerecord(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(1000);

            //delete record
            IWebElement deleteRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteRecord.Click();

            // Click OK
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);

            //check if recored deleted
            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (editedCode.Text != "Project2")
            {
                Assert.Pass("New record has been deleted successfully.");
            }
        }
    }
}
