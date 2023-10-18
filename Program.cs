using System;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the number that will start with
            string num = "1";

            //I defined here number 10 to give me 10 lines
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num);
                num = testFunction(num);
            }
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
