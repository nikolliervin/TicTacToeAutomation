﻿using OpenQA.Selenium.Chrome;

namespace TicTacToeAutomation
{
    public class TicTacToeAutomation
    {

        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            var steps = new Steps();

            steps.GoToURL(driver);
            steps.PlaySquareOfIndex(driver, 1);
            driver.Quit();

        }
    }
}
