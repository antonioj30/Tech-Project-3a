using System;
using System.Runtime.CompilerServices;
/*
    Author: Antonio Jones
    Date: 9/24/2020
    Comments: This is C# Console application code that demonstraed methods learned from 
    class this week. This is ssignment will ask the user to enter their name. Then
    write a Method that prints to the Console. "Hello username* insert real name)
    This assignment is called Tech Project 3a. 
*/
namespace Tech_Project_3a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for users input
            Console.WriteLine("Please enter your name");
            /*
                Using the try catch block to validate user input.
            */
            try
            {
                // This variale will gather data from user input
                string name = Console.ReadLine();
                greeting(name);

               
                Console.WriteLine("");
                Console.WriteLine("Press any key to exit the prgram");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter your name.");
                Console.WriteLine("");
                Console.WriteLine("Press any ket to exit the program and try again");
                Console.ReadKey (true);
            }// End of catch
            
        }
        //created string for our output
        private static void greeting(string name)
        {
            Console.WriteLine("");
            Console.WriteLine("Hello" + name + "-Go Bucs!");
        }// End of greeting
    }// End of class
}// End of namespace
