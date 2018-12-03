using System;
using System.Text;

namespace Module2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            Console.WriteLine("How many fruits: ");

            int number = int.Parse(Console.ReadLine());
            char spis = ' ';

              for (int i = 0; i < number; i++)
              {
                Console.Write("Enter fruit: ");
                string frukt = Console.ReadLine();
                sb.Append(frukt+spis); 
              }

            string result = sb.ToString();
            result.Trim(spis);
            Console.WriteLine($"{result}");
            Console.WriteLine(result);

        }
    }
}
