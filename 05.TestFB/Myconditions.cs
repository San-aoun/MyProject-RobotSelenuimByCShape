using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class Myconditions
{
    public static Func<IWebDriver, bool> ElementIsVisible(IWebElement element)
    {
        return (driver) =>
        {
            try
            {
                Thread.Sleep(2000);
                return element.Displayed;
            }
            catch (Exception)
            {
                // If element is null, stale or if it cannot be located
                return false;
            }
        };
    }
}

