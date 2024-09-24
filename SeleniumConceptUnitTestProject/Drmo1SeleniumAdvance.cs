using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AutomationSolution.SeleniumConceptUnitTestProject
{
    
    public class Drmo1SeleniumAdvance
    {
        [Test]
        public void Demo1MultipleTabTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/";

            //click on phpMyAdmin »

            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();
            // driver.FindElement(By.XPath("//b[contains(text(),'phpMyAdmin')]")).Click();

            //switch to 2nd tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Id("input_username")).SendKeys("john");
            driver.FindElement(By.Id("input_password")).SendKeys("John123");
            driver.FindElement(By.Id("input_go")).Click();


            //close the current tab
            driver.Close();

            //switch to 1st tab
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            //print title
            Console.WriteLine(driver.Title);


            driver.Quit();

        }

        [Test]
        public void Demo2TabsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.online.citibank.co.in/";

            //close all popup
            //click on Banking
            //click on Citi Commercial Bank
            //click on Branch/ATM
            //Select Citibank ATM as Bengaluru 

            driver.FindElement(By.ClassName("newclose")).Click();
            driver.FindElement(By.ClassName("newclose2")).Click();

            driver.FindElement(By.Id("topMnubanking")).Click();
            driver.FindElement(By.LinkText("Citi Commercial Bank")).Click();
            
            //switch to 2nd window
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            // driver.FindElement(By.XPath("//a[contains(text(),'Branch/ATM')]")).Click();

            driver.FindElement(By.LinkText("Branch/ATM")).Click();

            // dropdown without select tag
            driver.FindElement(By.XPath("//a[text()='Choose One']")).Click();
            driver.FindElement(By.LinkText("Bengaluru")).Click();



        }
       
    }
}
