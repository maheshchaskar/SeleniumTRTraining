using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace SeleniumConceptUnitTestProject
{
    public class Demo4SeleniumAdvance
    {
        [Test]
        public void ValidDocUploadTest()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.ilovepdf.com/pdf_to_word";

            //upload file

            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(@"C:\W21.pdf");
        }

        [Test]
      public void  Demo3ActionsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://futureskillsprime.in/";


            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//span[text()='Explore']"))).Perform();

            //mouse over on FutureSkills Prime
            actions.MoveToElement(driver.FindElement(By.XPath("//a[contains (text(),'FutureSkills Prime')]"))).Perform();

            driver.FindElement(By.XPath("//a[text()='About Us']")).Click();

        }
    }
}
