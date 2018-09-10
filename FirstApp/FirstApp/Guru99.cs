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
            browser.Close();
        }


        [TestMethod]
        public void Test1()
        {
            Console.WriteLine("Start test"); ;

            Thread.Sleep(10000);

            Console.WriteLine("Stop test"); ;

           
        }
    }
}
