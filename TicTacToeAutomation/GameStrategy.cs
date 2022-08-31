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
    }
}
