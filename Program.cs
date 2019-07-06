using System;

namespace git_example
{
    class Program
    {
        private static bool IsCalling(bool ringing)
        {
            return ringing;
        }

        private static void Call()
        {
            System.Console.WriteLine("MoshiMoshi!");
        }
        static void Main(string[] args)
        {
            Call();var ring = "Iphone's ringtune";
            IsCalling(ring != null);
            Console.WriteLine("Hello World!");
        }
    }
}
