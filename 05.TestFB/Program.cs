using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using NUnit.Framework;
using System.Collections;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;


class Program
{

    static void Main()
    {
        var url = "https://www.facebook.com/";
        var email = "work_inhome@hotmail.co.th";
        var pass = "Tan121416";
        
        try
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(2000);
            WebDriverWait Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();

            // Step1 : Login            
            Wait.Until(Myconditions.ElementIsVisible(driver.FindElement(By.Id("email"))));
            driver.FindElement(By.Id("email")).SendKeys(email);
            driver.FindElement(By.Id("pass")).SendKeys(pass);
            driver.FindElement(By.Id("loginbutton")).Click();
            Thread.Sleep(3000);

            // Step2 : Post Someting in FB page
            Wait.Until(Myconditions.ElementIsVisible(driver.FindElement(By.Name("xhpc_message"))));
            IWebElement TextArea = driver.FindElement(By.Name("xhpc_message"));
            Thread.Sleep(2000);
            //TextArea.Click();
            TextArea.SendKeys("HelloWold Selenium by C#");

            // Step3 : Click On Post Buttons
            Thread.Sleep(2000);
            IWebElement PostBtn = driver.FindElement(By.XPath("//*[@data-testid='react-composer-post-button']"));
            PostBtn.Click();
            Thread.Sleep(3000);
            driver.Close();

        }
        catch (Exception e)
        {
            throw e;
        }

    }
    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        //Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        //Console.ForegroundColor = ConsoleColor.White;
    }

}

