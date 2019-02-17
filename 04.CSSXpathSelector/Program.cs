using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        string url = "http://testing.todvachev.com/selectors/css-path/";
        string cssPath = "#post-108 > div > figure > img";
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);
        
        IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));
        IWebElement xPartElement = driver.FindElement(By.XPath(xPath));
        

        if (xPartElement.Displayed)
        {
            GreenMessage("Yes, I can see the element Xpath, It's rigth there!!");
        }
        else
        {
            RedMessage("No, Someting wrong!");
        }

        if (cssPathElement.Displayed)
        {
            GreenMessage("Yes, I can see the CSS, It's rigth there!!");
        }
        else
        {
            RedMessage("No, Someting wrong!");
        }
        driver.Close();
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
