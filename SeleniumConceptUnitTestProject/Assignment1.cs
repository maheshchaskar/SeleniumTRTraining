using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConceptUnitTestProject
{
    public class Assignment1
    {
        [Test]
    public void OpenEmr()
        {
            IWebDriver driver= new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "http://demo.openemr.io/b/openemr/";

            driver.FindElement(By.Name("authUser")).SendKeys("admin");
            driver.FindElement(By.Name("clearPass")).SendKeys("pass");

            driver.FindElement(By.XPath("//option[@value='18']")).Click();

           // driver.SwitchTo().DefaultContent();

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

           // driver.SwitchTo().Alert().Accept();




        }
    }
}
