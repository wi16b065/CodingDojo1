using CodingDojo1.StackData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingDojo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            IStack<int> testStack = new IStack<int>();

            if (testStack.isEmpty())
            {
                Console.WriteLine("Stack is empty.");
            }

            testStack.Push(100);
            testStack.Push(200);
            testStack.Push(300);
            testStack.Push(400);
            testStack.Push(500);

            while (!testStack.isEmpty())
            {
                sum += testStack.Peek();
                Console.WriteLine(testStack.Pop());
            }

            if (testStack.isEmpty())
            {
                Console.WriteLine("Stacksum: " + sum);
                Console.WriteLine("Stack is empty again.");
            }
            
            Console.ReadLine();
        }
    }
}
