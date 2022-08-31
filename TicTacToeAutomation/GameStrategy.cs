using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace TicTacToeAutomation
{
    public class GameStrategy : Elements
    {
        public int PickAndPushOut(List<int> numbers)
        {
            Random random = new Random();
            int number = random.Next(numbers.Count);
            numbers.Remove(number);
            return number;
        }

        public void RemoveState(int number, List<int> list)
        {
            list.Remove(number);
        }

        public void CheckRemoveStateBusy(ChromeDriver driver, List<int> list)
        {
            foreach (var item in list)
            {
                if (driver.FindElement(CheckSquareOfIndex(item)).GetAttribute("class") == "o")
                {
                    list.Remove(item);
                }

            }

        }
    }
}
