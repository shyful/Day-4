using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingforeachApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            foreach(int items in stack){
            Console.WriteLine(items);
            }
            Console.WriteLine(stack.Count());
            }

    }
}
