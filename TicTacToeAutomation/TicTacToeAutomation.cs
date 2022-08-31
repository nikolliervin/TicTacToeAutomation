using OpenQA.Selenium.Chrome;

namespace TicTacToeAutomation
{
    public class TicTacToeAutomation
    {

        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            var steps = new Steps();

            steps.GoToURL(driver);
            steps.PlaySquareOfIndex(driver, 1);


        }
    }
}
