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
            char space = ' ';

                          for (int i = 0; i < number; i++)
                                   {
                                        Console.Write("Enter fruit: ");
                                          string frukt = Console.ReadLine();
                                              sb.Append(frukt+space); 
                                    }

            string result = sb.ToString();
            result.Trim(space);
            Console.WriteLine($"      {result}       ");
            Console.WriteLine(result);

        }
    }
}
