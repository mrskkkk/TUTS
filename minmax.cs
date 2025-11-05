using System;
using System.Collections.Generic;

public class StackWithInput
{
    public static void Main(string[] args)
    {

        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(25);
            stack.Push(5);
            int min = stack.Min();
            Console.WriteLine("\nMinimum element in the stack: " + min);


            int max = stack.Max();
            Console.WriteLine("\nMaximum element in the stack: " + max);


            Console.ReadKey();
        }
    }
}