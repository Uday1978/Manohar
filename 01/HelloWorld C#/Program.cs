//single line comment
//Pre-defined namespace
using System;
//User defined namespace
namespace HelloWorld
{
    //Type (class, interface, structs, enums, delegates)
    class Program
    {
        //Type member
        static void Main()// main entry point of the program
        {
            Console.Write("Please enter your name ");
            string name;
            //Take input from user in string format
            name=Console.ReadLine();
            //Console.WriteLine($"Hello {name}"); // extrapolated string
            //Console.WriteLine("Hello "+ name); // concatenated string
            Console.WriteLine("Hello {0}! How are you?",name); // using placeholder
        }
    }
}
