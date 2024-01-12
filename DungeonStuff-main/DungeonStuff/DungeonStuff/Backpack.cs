using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonStuff
{
    class Backpack
    {
        public static void BackpackDraw()
        {
            Console.SetCursorPosition(97, 2);
            Menu.ColorConsoleOutput(ConsoleColor.Yellow, "Backpack");



        }

        public static void BackpackDrawFight()
        {
            Console.SetCursorPosition(94, 22);
            Menu.ColorConsoleOutput(ConsoleColor.Yellow, "Backpack");

        }
    }
}
