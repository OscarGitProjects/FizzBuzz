using System;
using System.IO;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();

            Console.WriteLine("Fizz Buzz!");

            try
            {
                // Hämta alla filerna från Data katalogen
                string[] arrFiles = Directory.GetFiles(@".\Data\");

                foreach (string file in arrFiles)
                {
                    // Läs varje fil för sig och anropa FizzBuzz
                    using (StreamReader fileStream = new StreamReader(file))
                    {
                        string ln;

                        while ((ln = fileStream.ReadLine()) != null)
                        {
                            ln = ln.Trim();

                            Console.WriteLine("File data: " + ln);

                            string[] arrFileData = ln.Split();
                            if (arrFileData.Length == 3)
                            {
                                try
                                {
                                    int x = Int32.Parse(arrFileData[0].Trim());
                                    int y = Int32.Parse(arrFileData[1].Trim());
                                    int n = Int32.Parse(arrFileData[2].Trim());

                                    app.FizzBuzz(x, y, n);
                                }
                                catch (Exception)
                                { }
                            }
                        }

                        fileStream.Close();
                    }
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine("Exception! " + exc);
            }

            /*
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
            }*/

            Console.WriteLine("Press a key to end");
            Console.ReadLine();
        }


        /// <summary>
        /// FizzBuzz
        /// Jämnt delbart x ger utskriften Fizz,
        /// Jämnt delbart med y ger utskriften Buzz,
        /// Jämnt delbart med både x och y ger utskriften FizzBuzz
        /// Anars skrivs bara värdet ut
        /// </summary>
        /// <param name="x">Jämnt delbart x ger utskriften Fizz</param>
        /// <param name="y">Jämnt delbart med y ger utskriften Buzz</param>
        /// <param name="n">Antalet integers som skall skrivas ut. 1 till och med n</param>
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

            Console.WriteLine(System.Environment.NewLine);
        }
    }
}
