using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class ColorConsoleProgress : IProgress<int>
    {
        public void Report(int value)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(".");
            Console.ResetColor();
        }
    }
}
