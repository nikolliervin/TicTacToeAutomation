using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace TicTacToeAutomation
{
    public class GameStrategy : Elements
    {
        public int PickAState(List<int> numbers, Random random)   //random is not thread safe
        {
            int number = random.Next(numbers.Count);
            return number;
        }


        public void CheckRemoveStateBusy(ChromeDriver driver, List<int> list)
        {
            foreach (var item in list)
            {
                if (driver.FindElement(CheckSquareOfIndex(item)).GetAttribute("class") == "o" ||
                    driver.FindElement(CheckSquareOfIndex(item)).GetAttribute("class") == "x")
                {
                    list.Remove(item);
                    break;
                }

            }

        }
    }
}
