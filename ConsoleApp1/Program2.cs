using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            //DesiredCapabilities capability = new DesiredCapabilities();
            string cloudHost = "BrowserStack";
            //string cloudHost = "LambdaTest";
            AppiumOptions capability = new AppiumOptions();

            if (cloudHost.Equals("BrowserStack"))
            {
                Console.WriteLine("Browserstack..");
                capability.AddAdditionalCapability("browserName", "Android");
                capability.AddAdditionalCapability("device", "Google Pixel 3");
                capability.AddAdditionalCapability("os_version", "10.0");
                //capability.AddAdditionalCapability("browserName", "Safari");
                //capability.AddAdditionalCapability("device", "iPhone 11");
                //capability.AddAdditionalCapability("os_version", "14");
                capability.AddAdditionalCapability("realMobile", "true");
                capability.AddAdditionalCapability("project", "Android/IOS Brrowser Project");
                capability.AddAdditionalCapability("build", "Test Google Build");
                capability.AddAdditionalCapability("browserstack.user", "navkunjkumar1");
                capability.AddAdditionalCapability("browserstack.key", "AjFHUwkUxk7rhTprqBmE");
                driver = new RemoteWebDriver(
                  new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capability );

            } else {

            Console.WriteLine("LambdaTest..");
            capability.AddAdditionalCapability("build", "Test Google Build");
            capability.AddAdditionalCapability("name", "Android/IOS Brrowser Project");
            capability.AddAdditionalCapability("platformName", "Android");
            capability.AddAdditionalCapability("deviceName", "Google Pixel 3");
            capability.AddAdditionalCapability("platformVersion", "10");
            //capability.AddAdditionalCapability("platformName", "iOS");
            //capability.AddAdditionalCapability("deviceName", "iPad (6th generation)");
            //capability.AddAdditionalCapability("platformVersion", "13.1");
            driver = new RemoteWebDriver(
              new Uri("https://agore:kDsO40zMp5T8Xa6OsXeJUk0JORXUeReqOKZ3bUaWdxUM7qyfq7@hub.lambdatest.com/wd/hub"), capability);
            }

            driver.Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine(driver.Title);
            IWebElement txtSearch = driver.FindElement(By.Name("q"));
            txtSearch.SendKeys("Disney world");
            txtSearch.Submit();

            Console.WriteLine(driver.Title);
            driver.Quit();
        }
    }
}