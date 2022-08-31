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
            var IStartFirst = true;

            steps.GoToURL(driver);

            List<int> favoriteStates = new List<int>() { 1, 3, 5, 7, 9 };
            Random random = new Random();

            while (IStartFirst)
            {
                steps.PlaySquareOfIndex(driver, random.Next(favoriteStates.Count));

                if (!steps.IsFreeSqureOfIndex(driver, 1))
                {
                    steps.PlaySquareOfIndex(driver, 1);
                }
                else if (!steps.IsFreeSqureOfIndex(driver, 1)) { }


            }



        }
    }
}
