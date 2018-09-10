using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstApp
{
    [TestClass]
    public class Guru99
    {
        private IWebDriver browser;

        [TestInitialize]
        public void startBrowser()
        {
            browser = new ChromeDriver();
            browser.Url = "https://www.guru99.com/";
            browser.Manage().Window.Maximize();
            browser.Navigate().GoToUrl("https://www.guru99.com/");
            browser.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 5);
            browser.Manage().Timeouts().AsynchronousJavaScript = new TimeSpan(0, 0, 10);
            browser.Manage().Timeouts().PageLoad = new TimeSpan(0, 0, 15);
        }

        [TestCleanup]
        public void TearDown()
        {
        //  browser.Close();
        }


        [TestMethod]
        public void Test1()
        {

            IWebElement testing = browser.FindElement(By.XPath(".//div[@class='maxiroundedcenter']/ul/li[3]/a"));
            testing.Click();
            IWebElement manualTesting = browser.FindElement(By.XPath(".//*[@id='maximenuck243']/div[5]/div[1]/div/div[1]/ul/li[1]/a/span"));
            manualTesting.Click();

<<<<<<< HEAD
            browser.Close();
<<<<<<< HEAD
            browser.Manage().Window.Minimize();
            browser.Manage().Window.Maximize();
=======
>>>>>>> parent of be20b3b... added minimize option

=======
>>>>>>> parent of 9a741de... added new line in Test1

           
        }
    }
}
