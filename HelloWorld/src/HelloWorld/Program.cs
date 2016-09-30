using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(SayHello());
            }
            Console.ReadLine();

        }

        private static string SayHello()
        {
            String hello = "Hello C# from a function";
            return hello;
        } 
    }
}
