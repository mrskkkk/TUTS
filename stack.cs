using System;
using System.Collections.Generic;

public class StackWithInput
{
    public static void Main(string[] args)
    {
        // Create a new stack to store strings
        Stack<string> myStack = new Stack<string>();

        Console.WriteLine("Enter items to add to the stack (type 'exit' to stop):");

        string input;
        
        // --- Input Loop ---
        do
        {
            Console.Write("Enter item: ");
            input = Console.ReadLine(); // Read user input

            if (input.ToLower() != "exit")
            {
                myStack.Push(input); // Push the input onto the stack
                Console.WriteLine($"'{input}' pushed to stack.");
            }
        } 
        while (input.ToLower() != "exit");

        // --- Output Section ---
        Console.WriteLine("\nStack contents (popping elements):");
        
        // Pop and display elements until the stack is empty
        while (myStack.Count > 0)
        {
            string poppedItem = myStack.Pop(); // Pop an item from the stack
            Console.WriteLine($"Popped: {poppedItem}");
        }

        Console.WriteLine("Stack is empty.");
        Console.ReadKey(); 
    }
}