﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept2
{
    public class Demo1FBLogin
    {
        static void Main1(string[] args)
        {
            IWebDriver driver=new ChromeDriver();

            driver.Url = "https://www.facebook.com/";

            driver.FindElement(By.Id("email")).SendKeys("hello12@gmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("Welcom123");
            driver.FindElement(By.Name("login")).Click();

            
        }
    }
}
