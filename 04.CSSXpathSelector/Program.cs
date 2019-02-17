using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        var url = "http://testing.todvachev.com/selectors/css-path/";
        var cssPath = "";
        var xPath = "";

        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url);

        try
        {
            cssPath = "#post-108 > div > figure > img";
            xPath = "//*[@id=\"post-107\"]/div/figure/img";

            IWebElement[] arr = new IWebElement[2];
            arr[0] = driver.FindElement(By.CssSelector(cssPath));
            arr[1] = driver.FindElement(By.XPath(xPath));

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i].Displayed == true)
                {
                    GreenMessage("Yes, I can see the element , It's rigth there!!");
                }
                else
                {
                    RedMessage("No, Someting wrong!");
                }
            }
                      
        }
        catch(Exception)
        {
            RedMessage("system err");
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
