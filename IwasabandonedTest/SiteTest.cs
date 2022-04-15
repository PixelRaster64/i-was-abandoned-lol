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
        public static Boolean Test2(IWebDriver driver)
        {
            try
            {
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmail.com", "Pixel", "password", "password",
                    "(555) 555-5555", "New Brunswick", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");
                IWebElement lblSuccess = driver.FindElement(By.ClassName("text-success"));
                String strSuccess = lblSuccess.Text;
                if (strSuccess.Contains("Registration Successful!"))
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
            }
        }

        static void fillSignup(IWebDriver driver, String strFirst, String strLast, String strEmail,
            String strUser, String strPass, String strCon, String strPhone, String strProv,
            String strAdd, String strPost, String strUrl, String strDesc, String strLoc)
        {
            driver.Url = "http://47.55.247.242/site11/login.php";
            IWebElement linSignup = driver.FindElement(By.LinkText("Click Here"));
            linSignup.Click();
            IWebElement txtFirstname = driver.FindElement(By.Id("firstname"));
            txtFirstname.SendKeys(strFirst);

            IWebElement txtLastname = driver.FindElement(By.Id("lastname"));
            txtLastname.SendKeys(strLast);

            IWebElement txtEmail = driver.FindElement(By.Id("email"));
            txtEmail.SendKeys(strEmail);

            IWebElement txtUsername = driver.FindElement(By.Id("username"));
            txtUsername.SendKeys(strUser);
            
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            txtPassword.SendKeys(strPass);

            IWebElement txtConPass = driver.FindElement(By.Id("confirm"));
            txtConPass.SendKeys(strCon);

            IWebElement txtPhone = driver.FindElement(By.Id("phone"));
            txtPhone.SendKeys(strPhone);
            
            IWebElement txtAddress = driver.FindElement(By.Id("address"));
            txtAddress.SendKeys(strAdd);

            IWebElement dropProv = driver.FindElement(By.Id("province"));
            SelectElement selectMonth = new SelectElement(province);

            //select the option by text.
            selectProv.SelectByText("strProv");

            IWebElement txtPostal = driver.FindElement(By.Id("phone"));
            txtPostal.SendKeys(strPost);

            IWebElement txtUrl = driver.FindElement(By.Id("url"));
            txtUrl.SendKeys(strUrl);

            IWebElement txtDesc = driver.FindElement(By.Id("desc"));
            txtDesc.SendKeys(strDesc);

            IWebElement txtLoc = driver.FindElement(By.Id("location"));
            txtLoc.SendKeys(strLoc);

            IWebElement btnButton = driver.FindElement(By.Id("button"));
            btnButton.Click();
        }
    }
}
