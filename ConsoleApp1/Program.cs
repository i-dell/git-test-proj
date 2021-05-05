using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Emplyee emplyee = new Emplyee();
            emplyee.id = 101;
            emplyee.namd = "Adil";
            emplyee.age = 30;
            emplyee.salary = 10950;

            emplyee emplyee1 = new emplyee();

            Console.WriteLine("Hello World!");
        }
    }
}
