//single line comment
//Pre-defined namespace
using System;
//User defined namespace
namespace HelloWorld
{
    enum Days
    {
        Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    //Type (class, interface, structs, enums, delegates)
    class Program
    {
        //Type member
        static void Main(string[] args)// main entry point of the program
        {
            Console.Write("Please enter your name ");
            string name;
            int a;         
            //Take input from user in string format
            name=Console.ReadLine();
            //Console.WriteLine($"Hello {name}"); // extrapolated string
            //Console.WriteLine("Hello "+ name); // concatenated string
            Console.WriteLine("Hello {0}! How are you?",name); // using placeholder
            Console.WriteLine("Today is "+DayOfWeek.Wednesday);
        }
    }
}
