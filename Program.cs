using System;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "";
            Console.WriteLine("Enter which number you would like to start with: ");
            num = Console.ReadLine();

            do
            {
                while(!Console.KeyAvailable)
                {
                    Console.WriteLine(num);
                    num = testFunction(num);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
        }

        public static string testFunction(String number)
        {
            StringBuilder result = new StringBuilder();

            char repeat = number[0];
            number = number.Substring(1) + " ";
            int time = 1;

            foreach (char actual in number)
            {
                if (actual != repeat)
                {
                    result.Append(time.ToString() + repeat);
                    time = 1;
                    repeat = actual;
                }
                else
                    time++;
            }

            return result.ToString();
        }
    }
}
