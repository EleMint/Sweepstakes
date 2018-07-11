using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UI
    {
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine().Trim();
        }
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
