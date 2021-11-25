using System;

namespace DataStructure_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Enter Progran number to get excuted \n1. Unordred list \n2. Exit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            UnorderedList unordered = new UnorderedList();
                            unordered.Operation();
                            break;
                        case 2:
                            flag = false;
                            break;

                    }
                }
            }
        }
    }
}
