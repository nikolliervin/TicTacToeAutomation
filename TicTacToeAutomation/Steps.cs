using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TicTacToeAutomation
{
    public class Steps : Elements
    {
        public void GoToURL(ChromeDriver driver)
        {
            driver.Navigate().GoToUrl("https://playtictactoe.org/");
        }

        public void PlaySquareOfIndex(ChromeDriver driver, int index)
        {
            Thread.Sleep(5000);
            driver.FindElement(SquareOfIndex(index)).Click();
            Thread.Sleep(5000);
        }


    }
}
