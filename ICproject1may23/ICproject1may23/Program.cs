
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using ICproject1may23.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();

        //create an object for loginpage
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.Loginsteps(driver);

        //create an object for Homepage
        HomePage HomePageObj = new HomePage();
        HomePageObj.GoToTMPage(driver);

        //create an obbject for Time&Managementpage
        Time_MntPage time_MntPageObj = new Time_MntPage();
        time_MntPageObj.CreateTimerecord(driver);
        time_MntPageObj.EditTimerecord(driver);
        time_MntPageObj.DeleteTimerecord(driver);

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        wait.Until(ExpectedConditions.ElemetToExist(By.Id("code")));




    }
}

