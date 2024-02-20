using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class StartUp
    {
        static void Main()
        {
            StackOfStrings stack = new();
            Console.WriteLine(stack.isEmpty());

            stack.AddRange(new string[] { "1", "asd" });

            Console.WriteLine(stack.isEmpty());

        }
    }
}
