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

            Console.WriteLine("SignTest2 - Sign Up");
            Boolean blnSignTest02;
            blnSignTest02 = SiteTest.SignTest2(driver);
            TestResult(blnSignTest02);
            
            Console.WriteLine("SignTest3 - email Validation");
            Boolean blnSignTest03;
            blnSignTest03 = SiteTest.SignTest2(driver);
            TestResult(blnSignTest03);


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
