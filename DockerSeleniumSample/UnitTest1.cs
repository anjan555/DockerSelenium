using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DockerSeleniumSample
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver driver;
        [TestMethod]

        public void TestMethod1()
        {
            var BrowserConfig = new BrowserConfiguration();

            Driver.driver = BrowserConfig.Browser("http://google.com");
            Driver.driver.FindElement(By.Name("q")).SendKeys("DevOn Bangalore");
            Driver.driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            Driver.driver.Quit();

        }
               
    }

    
}
