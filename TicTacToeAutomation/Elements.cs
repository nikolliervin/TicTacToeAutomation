using OpenQA.Selenium;

namespace TicTacToeAutomation
{
    public class Elements
    {
        public static By SquareOfIndex(int index) => By.XPath($"/html/body/div[3]/div[1]/div[{index}]");
    }
}
