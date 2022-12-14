using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace TicTacToeAutomation
{
    public class TicTacToeAutomation
    {

        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            var steps = new Steps();
            var game = new GameStrategy();
            var IStartFirst = true;

            steps.GoToURL(driver);

            List<int> favoriteStates = new List<int>() { 1, 3, 5, 7, 9 };
            List<int> allStates = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random random = new Random();

            while (IStartFirst)
            {
                try
                {
                    steps.PlaySquareOfIndex(driver, game.PickAState(favoriteStates));
                    game.CheckRemoveStateBusy(driver, allStates);
                    game.CheckRemoveStateBusy(driver, favoriteStates);
                }
                catch (Exception e)
                {

                    steps.PlaySquareOfIndex(driver, game.PickAState(allStates));
                }


                game.CheckRemoveStateBusy(driver, allStates);
                game.CheckRemoveStateBusy(driver, favoriteStates);








            }

            IStartFirst = false;



        }
    }
}
