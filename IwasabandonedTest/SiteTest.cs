using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MySql.Data.MySqlClient;

namespace IwasabandonedTest
{
    class SiteTest
    {
        private static MySqlConnection connection;
        public static void SiteReset()
        {
            // Setup the details for the connection
            // server - address of the server
            // database - database name of the site
            // uid - username to login to the database
            // pwd - password to login to the database
            string myConnectionString = "server=192.168.2.104;database=bitter-site11;uid=site11;pwd=gqEbZnDcLig8f8fe;";

            // Give the connection object the connection details
            connection = new MySqlConnection(myConnectionString);

            // Create a command to be run, runs the "non-query stored procedure" called 'reset'
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "reset";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // Open the connection, run the command, close the connection
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            //this thing sure does add alot of problems!
        }
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
        public static Boolean SignTest1(IWebDriver driver)
        {
            try
            {
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmail.com", "Pixel", "password", "password",
                    "(555) 555-5555", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
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
        
        public static Boolean SignTest2(IWebDriver driver)
        {
            try
            {
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64gmailcom", "Pixel", "password", "password",
                    "(555) 555-5555", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");
                IWebElement lblSuccess = driver.FindElement(By.ClassName("text-success"));
                String strSuccess = lblSuccess.Text;
                if (strSuccess.Contains("Registration Successful!"))
                    //no way to test for javascript alert tet
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static Boolean SignTest3(IWebDriver driver)
        {
            try
            {
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmail", "Pixel", "password", "password",
                    "(555) 555-5555", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");
                IWebElement lblSuccess = driver.FindElement(By.ClassName("text-success"));
                String strSuccess = lblSuccess.Text;
                if (strSuccess.Contains("Registration Successful!"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            catch
            {
                return false;
            }
        }
        public static Boolean SignTest4(IWebDriver driver)
        {
            try
            {
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmailcom", "Pixel", "password", "password",
                    "(555)  6 555555", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");
                IWebElement lblSuccess = driver.FindElement(By.ClassName("text-success"));
                String strSuccess = lblSuccess.Text;
                if (strSuccess.Contains("Registration Successful!"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            catch
            {
                return false;
            }
        }
        public static Boolean SignTest5(IWebDriver driver)
        {
            SiteReset();
            try
            {
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmailcom", "Pixel", "password", "what da dog doin?",
                    "(555) 555-5555", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");
                IWebElement lblSuccess = driver.FindElement(By.ClassName("text-success"));
                String strSuccess = lblSuccess.Text;
                if (strSuccess.Contains("Registration Successful!"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            catch
            {
                return false;
            }
        }
        public static Boolean SignTest6(IWebDriver driver)
        {
            SiteReset();
            try
            {
                fillSignup(driver, "Elliot", "Whippie", "", "Pixel", "password", "password",
                    "(555) 555-5555", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");
                IWebElement lblSuccess = driver.FindElement(By.ClassName("text-success"));
                String strSuccess = lblSuccess.Text;
                if (strSuccess.Contains("Registration Successful!"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            catch
            {
                return false;
            }
        }
        public static Boolean SignTest7(IWebDriver driver)
        {
            try
            {
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmailcom", "", "password", "password",
                    "(555) 555-5555", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");
                IWebElement lblSuccess = driver.FindElement(By.ClassName("text-success"));
                String strSuccess = lblSuccess.Text;
                if (strSuccess.Contains("Registration Successful!"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            catch
            {
                return false;
            }
        }
        public static Boolean SignTest8(IWebDriver driver)
        {
            SiteReset();
            try
            {
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmailcom", "Pixel", "", "password",
                    "(555) 555-5555", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");
                IWebElement lblSuccess = driver.FindElement(By.ClassName("text-success"));
                String strSuccess = lblSuccess.Text;
                if (strSuccess.Contains("Registration Successful!"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            catch
            {
                return false;
            }
        }
        public static Boolean SignTest9(IWebDriver driver)
        {
            SiteReset();
            try
            {
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmailcom", "Pixel", "password", "password",
                    "", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");
                IWebElement lblSuccess = driver.FindElement(By.ClassName("text-success"));
                String strSuccess = lblSuccess.Text;
                if (strSuccess.Contains("Registration Successful!"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            catch
            {
                return false;
            }
        }
        public static Boolean LoginTest1(IWebDriver driver)
        {
            SiteReset();
            try
            {
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmailcom", "Pixel", "password", "password",
                    "(555) 555-5555", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");
                fillLogin(driver, "", "password");
                if (driver.Url == ("http://47.55.247.242/site11/index.php"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            catch
            {
                return false;
            }
        }
        public static Boolean LoginTest2(IWebDriver driver)
        {
            SiteReset();
            try
            {
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmailcom", "Pixel", "password", "password",
                    "(555) 555-5555", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");
                fillLogin(driver, "Pixel", "");
                if (driver.Url == ("http://47.55.247.242/site11/index.php"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            catch
            {
                return false;
            }
        }
            public static Boolean LoginTest3(IWebDriver driver)
            {
                SiteReset();
                try
                {
                    fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmailcom", "Pixel", "password", "password",
                        "(555) 555-5555", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                        "in your walls");
                    fillLogin(driver, "Pixe64", "Ha! Gotee!");
                    if (driver.Url == ("http://47.55.247.242/site11/index.php"))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
        public static Boolean LoginTest4(IWebDriver driver)
        {
            SiteReset();
            try
            {
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmailcom", "Pixel", "password", "password",
                    "(555) 555-5555", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");
                fillLogin(driver, "bruh", "password");
                if (driver.Url == (""))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        public static Boolean LoginTest5(IWebDriver driver)
        {
            SiteReset();
            try
            {
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmailcom", "Pixel", "password", "password",
                    "(555) 555-5555", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");
                fillLogin(driver, "bruh", "password");
                if (driver.Url == ("http://47.55.247.242/site11/index.php"))
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
        public static Boolean SignTest10(IWebDriver driver)
        {
            try
            {
                SiteReset();
                driver.Url = "http://47.55.247.242/site11/login.php";
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmail.com", "Pixel", "password", "password",
                    "(555) 555-5555", "", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");
                IWebElement lblSuccess = driver.FindElement(By.ClassName("text-success"));
                String strSuccess = lblSuccess.Text;

                if (strSuccess.Contains("Registration Successful!"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static Boolean SignTest11(IWebDriver driver)
        {
            try
            {
                SiteReset();
                driver.Url = "http://47.55.247.242/site11/login.php";
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmail.com", "Pixel", "password", "password",
                    "(555) 555-5555", "New", "690 Yourmother Av.", "aaaaaaaaa!", "www.youtube.com", "Holy Crap",
                    "in your walls");
                IWebElement lblSuccess = driver.FindElement(By.ClassName("text-success"));
                String strSuccess = lblSuccess.Text;

                if (strSuccess.Contains("Registration Successful!"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static Boolean SignTest12(IWebDriver driver)
        {
            try
            {
                SiteReset();
                driver.Url = "http://47.55.247.242/site11/login.php";
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmail.com", "Pixel", "password", "password",
                    "(555) 555-5555", "New", "690 Yourmother Av.", "", "www.youtube.com", "Holy Crap",
                    "in your walls");
                IWebElement lblSuccess = driver.FindElement(By.ClassName("text-success"));
                String strSuccess = lblSuccess.Text;

                if (strSuccess.Contains("Registration Successful!"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static Boolean SignTest13(IWebDriver driver)
        {
            try
            {
                SiteReset();
                driver.Url = "http://47.55.247.242/site11/login.php";
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmail.com", "Pixel", "password", "password",
                    "(555) 555-5555", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");
                IWebElement lblSuccess = driver.FindElement(By.ClassName("text-success"));
                String strSuccess = lblSuccess.Text;

                if (strSuccess.Contains("Registration Successful!"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static Boolean SignTest14(IWebDriver driver)
        {
            try
            {
                SiteReset();
                driver.Url = "http://47.55.247.242/site11/login.php";
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmail.com", "Pixel", "password", "password",
                    "(555) 555-5555", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");
                fillSignup(driver, "Elliot", "Whippie", "pixelraster64@gmail.com", "Pixel", "password", "password",
                    "(555) 555-5555", "New", "690 Yourmother Av.", "I0I 0I0", "www.youtube.com", "Holy Crap",
                    "in your walls");


                IWebElement lblSuccess = driver.FindElement(By.ClassName("text-success"));
                String strSuccess = lblSuccess.Text;

                if (strSuccess.Contains("Registration Successful!"))
                {
                    return false;
                }
                else
                {
                    return true;
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
            //selectProv = new selectprov(dropProv);
            //selectProv.SelectByText("strProv");
            dropProv.SendKeys(strProv);

            IWebElement txtPostal = driver.FindElement(By.Id("postal"));
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
        static void fillLogin(IWebDriver driver, String strUser, String strPass)
        {
            IWebElement txtUsername = driver.FindElement(By.Id("username"));
            txtUsername.SendKeys(strUser);

            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            txtPassword.SendKeys(strPass);

            IWebElement btnButton = driver.FindElement(By.Id("button"));
            btnButton.Click();
        }
    }
}
