using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class 4ChangeLanguageTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void The4ChangeLanguageTest()
        {
            driver.Navigate().GoToUrl("https://bakeronline.be/be-en/");
            driver.FindElement(By.XPath("//footer[@id='footer']/div/div/button")).Click();
            driver.FindElement(By.XPath("//div[@id='app']/main/div[4]/div/div/div[2]/div[2]/button")).Click();
            driver.Navigate().GoToUrl("https://bakkersonline.be/be-nl/");
            driver.FindElement(By.XPath("//footer[@id='footer']/div/div/button")).Click();
            driver.FindElement(By.XPath("//div[@id='app']/main/div[4]/div/div/div[2]/div/button[2]")).Click();
            driver.Navigate().GoToUrl("https://bakeronline.be/be-fr/");
            driver.FindElement(By.XPath("//footer[@id='footer']/div/div/button")).Click();
            driver.FindElement(By.XPath("//div[@id='app']/main/div[4]/div/div/div[2]/div[3]/button[3]")).Click();
            driver.Navigate().GoToUrl("https://bakeronline.be/be-en/");
            driver.FindElement(By.XPath("//footer[@id='footer']/div/div/button")).Click();
            driver.FindElement(By.XPath("//div[@id='app']/main/div[4]/div/div/div[2]/div[2]/button[4]")).Click();
            driver.Navigate().GoToUrl("https://bakeronline.be/be-de/");
            driver.FindElement(By.XPath("//footer[@id='footer']/div/div/button")).Click();
            driver.FindElement(By.XPath("//div[@id='app']/main/div[4]/div/div/div[2]/div/button[3]")).Click();
            driver.Navigate().GoToUrl("https://bakeronline.be/be-en/");
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
