using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;



namespace SeleniumConcept
{
    public class Program
    {
         static void Main(String[] args)
    {
        IWebDriver obj = new EdgeDriver();

        obj.Url = "https://www.facbook.com";

        string actualTitle = obj.Title;
        Console.WriteLine(actualTitle);

            Console.WriteLine(obj.Title);
            Console.WriteLine(obj.Url);

        obj.Quit();
    }
}
}

