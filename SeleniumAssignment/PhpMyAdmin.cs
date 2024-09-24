using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAssignment
{
    public class PhpMyAdmin
    {
        public static void Main1(string[] args)
        {
            IWebDriver driver=new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.db4free.net/phpMyAdmin/";

            driver.FindElement(By.Id("input_username")).SendKeys("Admin");
            driver.FindElement(By.Id("input_password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//input[@value='Log in']")).Click();



        }
    }
}
