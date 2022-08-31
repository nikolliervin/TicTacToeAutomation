using OpenQA.Selenium.Chrome;

namespace TicTacToeAutomation
{
    public class TicTacToeAutomation
    {

        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            var steps = new Steps();
            var IStartFirst = true;

            steps.GoToURL(driver);

            while (IStartFirst)
            {
                steps.PlaySquareOfIndex(driver, 3);
                steps.IsFreeSqureOfIndex(driver, 1).Should().Be;
            }



        }
    }
}
