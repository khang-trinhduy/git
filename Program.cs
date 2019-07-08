using System;

namespace git_example
{
    class Program
    {
        private static void Call()
        {
            System.Console.WriteLine("MoshiMoshi!");
        }
        private static void Respond()
        {
            System.Console.WriteLine("Anou, Kono Denwabango ha...");
        }
        private static void Cancel()
        {
            System.Console.WriteLine(""); //add wrong number in japanese
        }
        static void Main(string[] args)
        {
            Call();
            Console.WriteLine("Hello World!");
        }
    }
}
