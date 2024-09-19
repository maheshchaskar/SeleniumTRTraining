using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConcept2
{
    public class Demo2FBSignup
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.facebook.com";

            //FindElement -- checks for presence of locator in 0.5s
            driver.FindElement(By.LinkText("Sign up for Facebook")).Click();
            driver.FindElement(By.Name("firstname")).SendKeys("John");
            driver.FindElement(By.Name("lastname")).SendKeys("wick");
            driver.FindElement(By.Name("reg_passwd__")).SendKeys("Welcome123");

            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day")));
            selectDay.SelectByText("17");
            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Id("month")));
            selectMonth.SelectByText("Jun");
            SelectElement selectYear = new SelectElement(driver.FindElement(By.Id("year")));
            selectYear.SelectByText("1992");

            //XPath
            driver.FindElement(By.XPath("//input[@value='-1']")).Click();
            //driver.FindElement(By.XPath("//label[text()='Custom']")).Click();






        }
    }
}
