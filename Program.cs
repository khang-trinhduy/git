using System;

namespace git_example
{
    class Program
    {
        private static bool IsCalling(bool ringing)
        {
            return ringing;
        }
        static void Main(string[] args)
        {
            var ring = "Iphone's ringtune";
            IsCalling(ring != null);
            Console.WriteLine("Hello World!");
        }
    }
}
