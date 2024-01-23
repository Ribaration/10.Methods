using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calling a method, this can be done many times, methods and function
            //are literally the same in C#, preferably call them methods
            SayHi();

            //Method with parameters
            SayHiUser("Evans");

            //Method with more parameters
            SayHiAge("John", 55);
            //freezing the console
            Console.ReadLine();

        }
        //creating a method, ignore static for now, use capitals as per convention
        static void SayHi()
        {
            Console.WriteLine("Hi");
        }
        //method with one parameter
        static void SayHiUser(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void SayHiAge(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    } 

}
