using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IwasabandonedTest
{
    class SiteTest
    {
        public static Boolean Test1(IWebDriver driver)
        {
            try
            {
                driver.Url = "http://47.55.247.242/site11/login.php";
                IWebElement linSignup = driver.FindElement(By.LinkText("Click Here"));
                linSignup.Click();

                if (driver.Url == ("http://47.55.247.242/site11/signup.php"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
                //Console.WriteLine("Test1 error link did not work");
            }
        }
        static void fillForm(IWebDriver driver, String strSubject, String strEmail, String strOrderRef, String strMessage)
        {
        }
}
