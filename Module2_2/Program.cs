using System;
using System.Text;

namespace Module2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many fruits: ");

            int number = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            char spis = ' ';

                          for (int i = 1; i > number; i++)
                                   {
                                        Console.Write("Enter fruit: ");
                                          string frukt = Console.ReadLine();
                                              sb.Append(frukt+spis); 
                                    }

            string result = sb.ToString();
            result.Trim(',');
            Console.WriteLine($"      {result}       ");
            Console.WriteLine(spis);

        }
    }
}
