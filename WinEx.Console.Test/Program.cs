using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinEx.Console.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("program start.press any key to start:");
            System.Console.ReadKey();
            InterceptKeys.Run();
            System.Console.WriteLine("press the key to end: Ctrl+c");
            while (true)
            {
                var key = System.Console.ReadKey().Key;
                if (key == ConsoleKey.E)
                {
                    InterceptKeys.Disable();
                    System.Console.WriteLine("app exit.");
                    Environment.Exit(0);
                }
            }
        }
    }
}
