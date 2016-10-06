using System;
using HelloWorld;

namespace HelloWorld
{
    internal class Program
    {
        protected static void Main(string[] args)
        {
            string ar="";
            if (args.Length < 1)
            {
                Console.WriteLine("No arguments, program requires at least one argument");
                return;
            }

            /*
             * var module = new HelloModule();
            Console.WriteLine(module.SayHello(args[0]));
            Console.ReadLine();
            */
            Console.WriteLine("Starting test...\n");

            Console.WriteLine("Arguments:");
            for (int i = 0; i < args.Length; i++)
            {
                ar = ar + args[i] + " ";
            }
            ar = ar.TrimEnd();
                
            Console.WriteLine(ar + "\n");

            Console.WriteLine("HomeWork 1\n");

            var HomeWorkObj1 = new HelloWorld.HomeWork();
            Console.WriteLine("Hello, " + HomeWorkObj1.SentenceCase(args));


            Console.WriteLine("\nHomeWork 2\n");
            var HomoWorkObj2 = new HelloWorld.HomeWorkV2();

            Console.WriteLine("Most frequently used symbol is : " + HomoWorkObj2.MaxSymbol(ar) + "\n\n");
            Console.WriteLine("Test Hello, " + HomoWorkObj2.SentenceCase(args));

            Console.ReadLine();
        }
    }
}
