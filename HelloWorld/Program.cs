using System;

namespace HelloWorld
{
    internal class Program
    {
        protected static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("No arguments, program requires at least one argument");
                return;
            }

            Console.WriteLine(string.Format("Hello World - {0}!", args[0]));
            Console.ReadLine();
        }
    }
}
