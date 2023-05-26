using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICproject1may23.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ICproject1may23.Utilities;
using NUnit.Framework;

namespace ICproject1may23.Tests 
{
    [TestFixture]
    public class TimeandMtests : Commondriver
    {
        [SetUp]
        public void SetUpActions()
        {
            //Open Chrome browser
            driver = new ChromeDriver();

            //LoginPage object initialization and defnition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.Loginsteps(driver);

            //create an object for Homepage
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToTMPage(driver);

        }
        [Test]
        public void CreateTimetests() 
        {
            Time_MntPage time_MntPageObj = new Time_MntPage();
            time_MntPageObj.CreateTimerecord(driver);
        }
        [Test]
        public void editTimetests() 
        {
            Time_MntPage time_MntPageObj = new Time_MntPage();
            time_MntPageObj.EditTimerecord(driver);
        }
        [Test]
        public void deleteTimetests() 
        {
            Time_MntPage time_MntPageObj = new Time_MntPage();
            time_MntPageObj.DeleteTimerecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
