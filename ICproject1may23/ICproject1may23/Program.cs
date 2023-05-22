using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

public class Program
{
    private static void Main(string[] args)
    {

        IWebDriver driver = new ChromeDriver();

        // launch the turnup portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        driver.Manage().Window.Maximize();

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
        Thread.Sleep(2000);
        // Create new record
        IWebElement Administrationtab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        Administrationtab.Click();
        Thread.Sleep(2000);

        IWebElement TimeMatbutton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        TimeMatbutton.Click();
        Thread.Sleep(2000);

        IWebElement CreateNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        CreateNew.Click();

        IWebElement typecode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        typecode.Click();
        Thread.Sleep(2000);

        IWebElement time = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
        time.Click();

        IWebElement fieldcode = driver.FindElement(By.Id("Code"));
        fieldcode.SendKeys("Project1");

        IWebElement fieldDescription = driver.FindElement(By.Id("Description"));
        fieldDescription.SendKeys("First Project");
        Thread.Sleep(2000);

        IWebElement fieldPrice = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        fieldPrice.SendKeys("60");

        IWebElement Savebutton = driver.FindElement(By.Id("SaveButton"));
        Savebutton.Click();
        Thread.Sleep(2000);

        IWebElement LastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        LastPage.Click();
        Thread.Sleep(2000);

        //check if record created
        IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

        if (newCode.Text == "Project1")
        {
            Console.WriteLine("Record Project1 created successfully.");
        }
        else
        {
            Console.WriteLine("Time record Project1 has not been created successfully.");
        }
        
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
        Thread.Sleep(2000);

        //edit the description name
        IWebElement fieldDescription1 = driver.FindElement(By.Id("Description"));
        fieldDescription1.Clear();
        fieldDescription1.SendKeys("Second Project");
        Thread.Sleep(3000);

        IWebElement Savebutton1 = driver.FindElement(By.Id("SaveButton"));
        Savebutton1.Click();
        Thread.Sleep(3000);
       
        //navigate to lastpage button
        IWebElement LastPage1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        LastPage1.Click();
        Thread.Sleep(2000);


        //check if recored edited 
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

        Thread.Sleep(2000);
        //delete the record
        IWebElement Deletebutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
        Deletebutton.Click();
        var alert = driver.SwitchTo().Alert();
        Thread.Sleep(3000);
        alert.Accept();
        Console.WriteLine("Time record Project2 deleted successfully.");
    }
}

