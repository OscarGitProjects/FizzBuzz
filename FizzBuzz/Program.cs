using System;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();

            Console.WriteLine("Fizz Buzz!");

            if(args.Length == 3)
            {
                try
                {
                    int x = Int32.Parse(args[0]);
                    int y = Int32.Parse(args[1]);
                    int n = Int32.Parse(args[2]);

                    app.FizzBuzz(x, y, n);
                }
                catch(Exception exc)
                {
                    Console.WriteLine("Exception!");
                }

            }

            Console.WriteLine("Press a key to end");
            Console.ReadLine();
        }


        private void FizzBuzz(int x, int y, int n)
        {
            int moduloX = 0;
            int moduloY = 0;
            String str = String.Empty;

            for (int i = 1; i <= n; i++)
            {
                moduloX = i % x;
                moduloY = i % y;

                if(moduloX == 0 && moduloY == 0)
                    str = "FizzBuzz";
                else if(moduloX == 0)
                    str = "Fizz";
                else if(moduloY == 0)
                    str = "Buzz";
                else
                    str = i.ToString();

                Console.WriteLine(str);
            }
        }
    }
}
