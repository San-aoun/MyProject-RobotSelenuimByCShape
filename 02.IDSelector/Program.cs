using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


class EntryPoint
{
    static void Main()
    {
        String url = "http://testing.todvachev.com/selectors/id/";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        IWebDriver element = driver.FindElement(By.Id("comment"));
    }
}

