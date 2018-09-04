using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerSeleniumSample
{
   public class BrowserConfiguration
    {
        public IWebDriver Browser(string url)
        {
            RemoteWebDriver driver;
            var des = new DesiredCapabilities();
            DesiredCapabilities capability = DesiredCapabilities.Chrome();
            des.SetCapability("version","");
            des.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Linux));
            driver = new RemoteWebDriver(new Uri("http://localhost:4449/wd/hub"),des);
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            return driver;
        }
    }
}
