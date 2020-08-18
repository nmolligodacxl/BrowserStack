//using System;
//using OpenQA.Selenium.Appium;
//using OpenQA.Selenium.Appium.Android;
//using OpenQA.Selenium.Remote;
//using OpenQA.Selenium.Support.UI;
//using System.Collections.Generic;

//namespace BrowserStackAppiumSingleTest
//{
//    class MainClass
//    {
//        readonly static string userName = "navkunjkumar1";
//        readonly static string accessKey = "AjFHUwkUxk7rhTprqBmE";

//        public static void Main(string[] args)
//        {
//            //DesiredCapabilities caps = new DesiredCapabilities();
//            AppiumOptions caps = new AppiumOptions();

//            caps.AddAdditionalCapability("browserstack.user", userName);
//            caps.AddAdditionalCapability("browserstack.key", accessKey);
//            caps.AddAdditionalCapability("device", "Google Pixel 3");
//            caps.AddAdditionalCapability("os_version", "9.0");
//            caps.AddAdditionalCapability("project", "My First Project");
//            caps.AddAdditionalCapability("build", "My First Build");
//            caps.AddAdditionalCapability("name", "Bstack-[C#] Sample Test");
//            caps.AddAdditionalCapability("app", "bs://c700ce60cf13ae8ed97705a55b8e022f13c5827c");

//            AndroidDriver<AndroidElement> driver = new AndroidDriver<AndroidElement>(new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);
//            AndroidElement searchElement = (AndroidElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
//                ExpectedConditions.ElementToBeClickable(MobileBy.AccessibilityId("Search Wikipedia"))
//            );
//            searchElement.Click();
//            AndroidElement insertTextElement = (AndroidElement)new WebDriverWait(driver, TimeSpan.FromSeconds(30)).Until(
//                ExpectedConditions.ElementToBeClickable(MobileBy.Id("org.wikipedia.alpha:id/search_src_text"))
//            );
//            insertTextElement.SendKeys("BrowserStack");
//            System.Threading.Thread.Sleep(5000);

//            IReadOnlyList<AndroidElement> allTextViewElements = driver.FindElementsByClassName("android.widget.TextView");
//            Console.WriteLine(allTextViewElements.Count > 0);

//            driver.Quit();
//        }
//    }
//}