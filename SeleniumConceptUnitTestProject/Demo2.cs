using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConceptUnitTestProject
{

    public class Demo2
    {
        [Test]
        public void AlertTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();
            //to inspect--> f12 or ctrl+shift+c

            //click on Go

            //java script alert from website
            //wait for alert present //explicit or fluent wait
            string actualAlertText = driver.SwitchTo().Alert().Text;

            Console.WriteLine(actualAlertText);

            driver.SwitchTo().Alert().Accept();
        }
    }
}
