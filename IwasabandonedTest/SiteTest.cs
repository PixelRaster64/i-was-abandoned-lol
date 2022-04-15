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
            string myConnectionString = "server=47.55.247.242;database=bitter-site11;uid=site11;pwd=ASMfoo34b3CdZoss;";

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
        public static Boolean Test2(IWebDriver driver)
        {
            SiteReset();
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
    }
}
