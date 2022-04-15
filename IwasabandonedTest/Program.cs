using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IwasabandonedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Selenium");

            Console.WriteLine("Test1 - Check link");
            Boolean blnTest01;
            blnTest01 = SiteTest.Test1(driver);
            TestResult(blnTest01);

            Console.WriteLine("Test2 - Sign Up");
            Boolean blnTest02;
            blnTest02 = SiteTest.Test2(driver);
            TestResult(blnTest02);


        }
        static void TestResult(Boolean blnResult)
        {
            if (blnResult)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }

        }
    }
}
