using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructure_Algorithm
{
    internal class UnorderedList
    {
        public void Operation()
        {
            string data = File.ReadAllText(@"E:\BridgeLAbz\Git\DataStructure-Algorithm\DataStructure-Algorithm\Utility\message.txt");
            Console.WriteLine("Reading File from the Message.txt");
            Console.WriteLine(data);
            string[] words = data.Split(' ');
            LinkedList<string> linkedlist = new LinkedList<string>();
            
            foreach (string item in words)
            {
                linkedlist.AddLast(item);
            }
           
            Display(linkedlist);
            Console.WriteLine("Enter the string want to search");
            string input = Console.ReadLine();
           
            if (linkedlist.Contains(input))
            {
                linkedlist.Remove(input);
                Console.WriteLine($"{input} Removed from the list");
            }
            else
            {
                linkedlist.AddLast(input);
                Console.WriteLine($"{input} Added to the list");
            }

            Console.WriteLine("Changes after Unordering");
            Display(linkedlist);
        }

        private void Display(LinkedList<string> linkedlist)
        {
            foreach (var item in linkedlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
