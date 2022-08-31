using OpenQA.Selenium.Chrome;
using System;

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

            int[] goodStateSquares = new int[] { 1, 3, 5, 7, 9 };

            while (IStartFirst)
            {
                steps.PlaySquareOfIndex(driver, Math.rand);

                if (!steps.IsFreeSqureOfIndex(driver, 1))
                {
                    steps.PlaySquareOfIndex(driver, 1);
                }
                else if (!steps.IsFreeSqureOfIndex(driver,))


            }



        }
    }
}
