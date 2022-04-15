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

            Console.WriteLine("SignTest1 - Sign Up");
            Boolean blnSignTest01;
            blnSignTest01 = SiteTest.SignTest1(driver);
            TestResult(blnSignTest01);

            Console.WriteLine("SignTest2 - no @ in email");
            Boolean blnSignTest02;
            blnSignTest02 = SiteTest.SignTest2(driver);
            TestResult(blnSignTest02);
            
            Console.WriteLine("SignTest3 - no email domain");
            Boolean blnSignTest03;
            blnSignTest03 = SiteTest.SignTest3(driver);
            TestResult(blnSignTest03);

            Console.WriteLine("SignTest4 - phone number in incorrect format");
            Boolean blnSignTest04;
            blnSignTest04 = SiteTest.SignTest4(driver);
            TestResult(blnSignTest04);

            Console.WriteLine("SignTest5 - password and confirmation different");
            Boolean blnSignTest05;
            blnSignTest05 = SiteTest.SignTest5(driver);
            TestResult(blnSignTest05);

            Console.WriteLine("SignTest6 - email empty");
            Boolean blnSignTest06;
            blnSignTest06 = SiteTest.SignTest6(driver);
            TestResult(blnSignTest06);

            Console.WriteLine("SignTest7 - username empty");
            Boolean blnSignTest07;
            blnSignTest07 = SiteTest.SignTest7(driver);
            TestResult(blnSignTest07);

            Console.WriteLine("SignTest8 - password empty");
            Boolean blnSignTest08;
            blnSignTest08 = SiteTest.SignTest8(driver);
            TestResult(blnSignTest08);

            Console.WriteLine("SignTest9 - phone number empty");
            Boolean blnSignTest09;
            blnSignTest09 = SiteTest.SignTest9(driver);
            TestResult(blnSignTest09);

            Console.WriteLine("LoginTest1 - username empty");
            Boolean blnLoginTest01;
            blnLoginTest01 = SiteTest.LoginTest1(driver);
            TestResult(blnLoginTest01);


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
