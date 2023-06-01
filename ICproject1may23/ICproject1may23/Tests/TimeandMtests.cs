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
using static System.Net.Mime.MediaTypeNames;

namespace ICproject1may23.Tests 
{
    [TestFixture]

    public class TimeandMtests : CommonDriver
    {
        [SetUp]
        public void SetUpActions()
        {
            //Open Chrome browser
            driver = new ChromeDriver();

            //LoginPage object initialization and defnition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.Loginsteps(driver);

            //Homepage object initialization and defnition
            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToTMPage(driver);

        }

        HomePage homePageObj = new HomePage();
        Time_MntPage tmPageObj = new Time_MntPage();

        [Test, Order(1)]
        public void CreateTimetests()
        {
            homePageObj.GoToTMPage(driver);
            tmPageObj.CreateTimerecord(driver);
        }
        [Test, Order(2)]
        public void editTimetests()
        {
            homePageObj.GoToTMPage(driver);
            //tmPageObj.EditTimerecord(driver);
        }
        [Test, Order(3)]
        public void deleteTimetests()
        {
            homePageObj.GoToTMPage(driver);
            tmPageObj.DeleteTimerecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        } 
    }
    }
