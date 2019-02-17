using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


class EntryPoint
{
    static void Main()
    {
        string url = "http://testing.todvachev.com/selectors/id/";
        string ID = "comment";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.Id(ID));

        if (element.Displayed)
        {
            GreenMessage("Yes, I can see the element, It's rigth there!!");
        }
        else
        {
            RedMessage("No, Someting wrong!");
        }
        driver.Close();
    }

    private static void RedMessage(string Message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Message);

    }

    private static void GreenMessage(string Message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Message);
    }

    
}

