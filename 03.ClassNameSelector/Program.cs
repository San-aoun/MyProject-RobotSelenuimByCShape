using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        string URL = "http://testing.todvachev.com/selectors/class-name/";
        string ClassName = "testClass";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(URL);
        IWebElement element = driver.FindElement(By.ClassName(ClassName));

        Console.WriteLine(element.Text);

        driver.Close();
    }
}
