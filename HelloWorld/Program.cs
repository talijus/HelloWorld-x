using System;
using HelloWorld;

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

            /*var module = new HelloModule();
            Console.WriteLine(module.SayHello(args[0]));
            Console.ReadLine();*/
            Console.WriteLine("Starting test...");
            Console.WriteLine(args[0]);

            var HomeWorkObj1 = new HelloWorld.HomeWork();
            Console.WriteLine(HomeWorkObj1.SentenceCase(args));

            

            var HomoWorkObj2 = new HelloWorld.HomeWorkV2();

            Console.ReadLine();
        }
    }
}
