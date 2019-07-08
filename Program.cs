using System;

namespace git_example
{
    class Program
    {
        private static void Call()
        {
            System.Console.WriteLine("MoshiMoshi!");
        }
        private static void Response()
        {
            System.Console.WriteLine("Anou, Kono Denwabango ha...");
        }
        private static void EndCall()
        {
            System.Console.WriteLine(""); //insert an japanese sentence for ending a phone call.
        }
        static void Main(string[] args)
        {
            Call();
            Console.WriteLine("Hello World!");
        }
    }
}
