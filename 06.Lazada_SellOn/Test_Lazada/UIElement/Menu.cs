using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Test_Lazada
{
    public class Menu
    {
        public Menu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "topActionSell")]
        public IWebElement MenuSellOnLazada { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#J_icms-5007388-1521617605051")]
        public IWebElement Login { get; set; }

        [FindsBy(How = How.Name, Using = "TPL_username")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Name, Using = "TPL_password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#J-m-content > div > div.c-right > div.row-form > form > div > div.button-submit > button")]
        public IWebElement Submit {get; set;}

    }


}
