using System;
using ICproject1may23.Pages;
using ICproject1may23.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ICproject1may23.StepDefinitions
{
    [Binding]
        public class TMFeatureStepDefinitions : CommonDriver
        {
            [Given(@"Logged into turnup portal successfully")]
            public void GivenLoggedIntoTurnupPortalSuccessfully()
            {
                driver = new ChromeDriver();

                // Login page object initialization and definition
                LoginPage loginPageObj = new LoginPage();
                loginPageObj.Loginsteps(driver);
            }

            [When(@"navigate to time and material page")]
            public void WhenNavigateToTimeAndMaterialPage()
            {
                HomePage homePageObj = new HomePage();
                homePageObj.GoToTMPage(driver);
            }

            [When(@"create a new time and material record")]
            public void WhenCreateANewTimeAndMaterialRecord()
            {
                Time_MntPage tmPageObj = new Time_MntPage();
                tmPageObj.CreateTimerecord(driver);
            }

            [Then(@"The record should be created successfully")]
            public void ThenTheRecordShouldBeCreatedSuccessfully()
            {
                Time_MntPage tmPageObj = new Time_MntPage();

                string newCode = tmPageObj.GetCode(driver);
                string newDescription = tmPageObj.GetDescription(driver);
                string newPrice = tmPageObj.GetPrice(driver);

                Assert.AreEqual("Project1", newCode, "Actual code and expected code does not match");
                Assert.AreEqual("Project1", newDescription, "Actual Description and expected Description does not match");
                Assert.AreEqual("$60.00", newPrice, "Actual price and expected price does not match");
            }

    [When(@"edit '([^']*)', '([^']*)' and '([^']*)' on an existing time and material record")]
        public void WhenEditAndOnAnExistingTimeAndMaterialRecord(string code, string description, string price)
        {
            Time_MntPage tmPageObj = new Time_MntPage();
            tmPageObj.EditTimerecord(driver, code, description, price);
        }

        [Then(@"The record should be edited '([^']*)', '([^']*)' and '([^']*)' successfully")]
        public void ThenTheRecordShouldBeEditedAndSuccessfully(string code, string description, string price)
        {
            Time_MntPage tmPageObj = new Time_MntPage();
            string createdcode = tmPageObj.GeteditedCode(driver);
            string createddescription = tmPageObj.GeteditedDescription(driver);
            string createdprice = tmPageObj.GeteditedPrice(driver);

            Assert.AreEqual(code, createdcode, "Actual code and expected code does not match");
            Assert.AreEqual(description, createddescription, "Actual descriptin and expected descriptino does not match");
            Assert.AreEqual(price, createdprice, "Actual price and expected price does not match");
        }
    }
}
