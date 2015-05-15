using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverViewApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack =new Stack<int>();

            myStack.Push(12454);
            myStack.Push(457);
            myStack.Push(4564);
            myStack.Push(784);

            int[] array = myStack.ToArray();
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);

            Console.WriteLine("**********");
 
            myStack.Pop();
            myStack.Pop();
            myStack.Peek();

 
            foreach (int i in myStack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("***********");
            
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
