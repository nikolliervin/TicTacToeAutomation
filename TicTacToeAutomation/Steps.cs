using OpenQA.Selenium.Chrome;

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
            driver.FindElement(SquareOfIndex(index)).Click();
        }


    }
}
