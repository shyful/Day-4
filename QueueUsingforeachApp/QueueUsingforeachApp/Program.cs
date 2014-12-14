using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingforeachApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> aQueue = new Queue<int>();
            aQueue.Enqueue(100);
            aQueue.Enqueue(150);
            aQueue.Enqueue(200);
            foreach (int items in aQueue)
            {
                Console.WriteLine(items);
            }
            Console.ReadKey();
        }
    }
}
