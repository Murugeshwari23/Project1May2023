using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

public class Program
{
    private static void Main(string[] args)
    {
        
        IWebDriver driver = new ChromeDriver();

        // launch turnup portal
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

        IWebElement Rememberme = driver.FindElement(By.)

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

