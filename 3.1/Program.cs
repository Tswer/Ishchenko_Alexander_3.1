using System;
using System.Collections.Generic;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> list = new List<int>() { 3, 4, 5, 6, 7, 8 };
                int k, C;
                Console.Write("k=");
                k = Convert.ToInt32(Console.ReadLine());
                Console.Write("C=");
                C = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("in list");
                foreach (int i in list)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                if (k > list.Count - 1)
                {
                    Console.WriteLine("Error k");
                }
                else
                {
                    list.Insert(k, C);
                    Console.WriteLine("out list");
                    foreach (int i in list)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }
}
