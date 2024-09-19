using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAssignment
{
    public class Salesforce
    {
        public static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";


            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("Wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");
            driver.FindElement(By.Name("UserTitle")).SendKeys("IT Manager");
            driver.FindElement(By.Name("CompanyName")).SendKeys("XYZ");
            driver.FindElement(By.Name("CompanyEmployees")).SendKeys("101-500 employees");
            driver.FindElement(By.Name("CompanyCountry")).SendKeys("United Kingdom");

            //driver.FindElement(By.XPath("//input[@type='checkbox']")).Click();

            driver.FindElement(By.Name("start my free trial")).Click();








        }
    }
}
