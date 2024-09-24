using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAssignment
{
    public class medibuddy
    {
        public static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.medibuddy.in/";

            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.ClassName("coperate")).Click();

            driver.FindElement(By.Name("corpphone")).SendKeys("865268");
            driver.FindElement(By.LinkText("Proceed")).Click();

            String GetErrorMsg = driver.FindElement(By.XPath("//div[contains(text(),'Please enter valid 10')]")).Text;
            Console.WriteLine(GetErrorMsg);


        }
    }
}

//Navigate onto https://www.medibuddy.in/
//Click on Login
//Click on I have an Insurance/Corporate Account
//Click on Login using Username &Password
//Enter username as john
//Enter password as john123
//Click on show password
//Click log in 
//Get the error message shown and print it in terminal 