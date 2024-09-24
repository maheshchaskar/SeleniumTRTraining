using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConceptUnitTestProject
{
    public class Demo3Frame
    {

        [Test]
        public void HdfcFrameTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));

            //enter userid as john123
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("john123");

            driver.FindElement(By.LinkText("CONTINUE")).Click();

            //switch to main html
            driver.SwitchTo().DefaultContent();

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));

            driver.FindElement(By.Id("fldPasswordDispId")).SendKeys("Welcome123");

            string actualAlertText = driver.SwitchTo().Alert().Text;

            Console.WriteLine(actualAlertText);

            driver.SwitchTo().Alert().Accept();


        }
    }
}
