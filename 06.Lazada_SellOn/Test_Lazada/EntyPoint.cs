using System;
using System.Threading;
using Test_Lazada;

class Program
{

    static void Main()
    {

        try
        {
            Menu GotoSellpage = new Menu();

            Driver.driver.Navigate().GoToUrl(Config.BaseUrl);
            GotoSellpage.MenuSellOnLazada.Click();
            GotoSellpage.Login.Click();
            Thread.Sleep(1000);
            GotoSellpage.Username.SendKeys(Config.Confidentail.Valid.username);
            GotoSellpage.Password.SendKeys(Config.Confidentail.Valid.password);
            GotoSellpage.Submit.Click();

        }
        catch (Exception e)
        {
            throw e;
        }
    }

 
}