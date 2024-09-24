using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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

            SelectElement selectTitle = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            selectTitle.SelectByText("IT Manager");
            driver.FindElement(By.Name("CompanyName")).SendKeys("XYZ");

            SelectElement selectCountry = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            selectCountry.SelectByText("United Kingdom");

            SelectElement selectEmployee = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectEmployee.SelectByText("201 - 500 employees");
            

            driver.FindElement(By.XPath("(//div[@class='checkbox-ui'])[2]")).Click();

            driver.FindElement(By.Name("start my free trial")).Click();

            //get header and print
            string actualHeader = driver.FindElement(By.TagName("h1")).Text;
            Console.WriteLine(actualHeader);

            //string actualError = driver.FindElement(By.XPath("//span[contains(text(),'valid phone')]"));
            //Console.WriteLine(actualError);



            // driver.FindElement(By.Name("UserTitle")).SendKeys("IT Manager");
            // driver.FindElement(By.Name("CompanyName")).SendKeys("XYZ");
            //driver.FindElement(By.Name("CompanyEmployees")).SendKeys("101-500 employees");
            // driver.FindElement(By.Name("CompanyCountry")).SendKeys("United Kingdom");

            //driver.FindElement(By.XPath("//input[@type='checkbox']")).Click();









        }
    }
}
