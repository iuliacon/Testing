﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver browser = new ChromeDriver();
            browser.Url = "https://www.guru99.com/";
            browser.Manage().Window.Maximize();
            browser.Navigate().GoToUrl("https://www.guru99.com/");
            browser.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 5);
            browser.Manage().Timeouts().AsynchronousJavaScript = new TimeSpan(0, 0, 10);
            browser.Manage().Timeouts().PageLoad = new TimeSpan(0, 0, 15);

        }
    }
}
