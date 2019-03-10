using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("what would you lke to do.");
            string user =  Console.ReadLine();
            if(user == "push")
            {
                Stack.push();
            }
            if (user == "pop")
            {
                Stack.Pop();
            }
            if (user == "clear")
            {
                Stack.clear();
            }
        }
    }
}
