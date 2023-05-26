using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICproject1may23.Utilities;
using OpenQA.Selenium;

namespace ICproject1may23.Pages
{
    public class LoginPage
    {
        public void Loginsteps(IWebDriver driver)
        {
         //launch the turnup portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        driver.Manage().Window.Maximize();

         //WaitTime.WaitToExist(driver, "Id", "UserName", 4);
        // enter valid username in the username field
        IWebElement usernamefield = driver.FindElement(By.Id("UserName"));
        usernamefield.SendKeys("hari");

        // enter valid password in the password field
        IWebElement passwordfield = driver.FindElement(By.Id("Password"));
        passwordfield.SendKeys("123123");

        // click login button
        IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginbutton.Click();
        Thread.Sleep(2000);

        // check if user has logeed in successfully
        IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        if (helloHari.Text == "Hello hari!")
        {
            Console.WriteLine("User Hello Hari has logged in successfully.");
        }
        else
        {
            Console.WriteLine("User Hello Hari logIn unsuccessfull.");
        }
    }
}
}
