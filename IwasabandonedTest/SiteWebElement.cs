using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IwasabandonedTest
{
    class SiteWebElement
    {
        public static IWebElement txtUsername(IWebDriver driver)
        {
            IWebElement txtUsername = driver.FindElement(By.Id("username"));
            return txtUsername;
        }
        public static IWebElement txtPassword(IWebDriver driver)
        {
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            return txtPassword;
        }
        public static IWebElement btnButton(IWebDriver driver)
        {
            IWebElement btnButton = driver.FindElement(By.Id("button")); //who in the world names button 'button'
            return btnButton;
        }
        public static IWebElement linSignUp(IWebDriver driver)
        {
            IWebElement linSignUp = driver.FindElement(By.LinkText("Click Here"));
            return linSignUp;
        }
        public static IWebElement txtFirstname(IWebDriver driver)
        {
            IWebElement txtFirstname = driver.FindElement(By.Id("firstname"));
            return txtFirstname;
        }
        public static IWebElement txtLastname(IWebDriver driver)
        {
            IWebElement txtLastname = driver.FindElement(By.Id("lastname"));
            return txtLastname;
        }
        public static IWebElement txtEmail(IWebDriver driver)
        {
            IWebElement txtEmail = driver.FindElement(By.Id("email"));
            return txtEmail;
        }
        public static IWebElement txtConPass(IWebDriver driver)
        {
            IWebElement txtConPass = driver.FindElement(By.Id("confirm"));
            return txtConPass;
        }
        public static IWebElement txtPhone(IWebDriver driver)
        {
            IWebElement txtPhone = driver.FindElement(By.Id("phone"));
            return txtPhone;
        }
        public static IWebElement txtAddress(IWebDriver driver)
        {
            IWebElement txtAddress = driver.FindElement(By.Id("address"));
            return txtAddress;
        }
        public static IWebElement dropProv(IWebDriver driver)
        {
            IWebElement dropProv = driver.FindElement(By.Id("province"));
            return dropProv;
        }
        public static IWebElement txtPostal(IWebDriver driver)
        {
            IWebElement txtPostal = driver.FindElement(By.Id("phone"));
            return txtPostal;
        }
        public static IWebElement txtUrl(IWebDriver driver)
        {
            IWebElement txtUrl = driver.FindElement(By.Id("url"));
            return txtUrl;
        }
        public static IWebElement txtDesc(IWebDriver driver)
        {
            IWebElement txtDesc = driver.FindElement(By.Id("desc"));
            return txtDesc;
        }
        public static IWebElement txtLoc(IWebDriver driver)
        {
            IWebElement txtLoc = driver.FindElement(By.Id("location"));
            return txtLoc;
        }
    }
}
