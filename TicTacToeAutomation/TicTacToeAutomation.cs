using OpenQA.Selenium;

namespace TicTacToeAutomation
{
    public class TicTacToeAutomation
    {

        static void Main(string[] args)
        {
            var driver = new IWebDriver();
            var steps = new Steps();

            steps.GoToURL(driver);
            steps.PlaySquareOfIndex(driver, 1);
            driver.Quit();

        }
    }
}
