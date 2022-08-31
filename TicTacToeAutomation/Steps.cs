using OpenQA.Selenium.Chrome;

namespace TicTacToeAutomation
{
    public class Steps : Elements
    {
        public void GoToURL(ChromeDriver driver)
        {
            driver.Navigate().GoToUrl("https://playtictactoe.org/");
        }

        public void PlaySquareOne(ChromeDriver driver)
        {
            driver.FindElement(SquareOfIndex(1)).Click();
        }
    }
}
