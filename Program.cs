using System;

namespace SUMA
{
    class Sum
    {
        int memory = 0;

        public void Add(int n)
        {
            memory = memory + n;
            Console.WriteLine(memory);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            int number;
            Sum sum = new Sum();

            while (line != null)
            {
                line = Console.ReadLine();
                if (line != null)
                {
                    number = int.Parse(line);
                    sum.Add(number);
                }
            }

        }
    }
}
