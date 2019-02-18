using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using NUnit.Framework;
using System.Collections;

class EntryPoint
{
    [TestFixture]
    public class Chrome_Sample_test
    {
        [Test(Description = "Check SauceLabs Homepage for Login Link")]
        static void Main()
        {
            var url = "http://testing.todvachev.com/selectors/css-path/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);

            try
            {
                IWebElement cssPath = driver.FindElement(By.CssSelector("#post-108 > div > figure > img"));
                IWebElement xPath = driver.FindElement(By.XPath("//*[@id=\"post-107\"]/div/figure/img"));

                IWebElement[] element = { cssPath , xPath }; 

                foreach (var i in element)
                {
                    if (i == cssPath)
                    {
                        GreenMessage("yes, i can see the element CSS , it's rigth there!!");
                    }
                    else
                    {
                        GreenMessage("yes, i can see the element XPATH , it's rigth there!!");
                    }

                }

            }
            catch (Exception)
            {
                RedMessage("no, someting wrong!");
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
}
