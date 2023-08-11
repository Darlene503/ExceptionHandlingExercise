using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            //  create an char[], it must contain 6 numbers and 3 letters - name it arr
            //  a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c', };
            var numbers = new List<int>();
            //var str = "";



            //TODO START HERE:

            // Make a foreach loop to iterate through your character array
            foreach (var c in arr)
            {



                try
                {
                    string str = c.ToString();
                    int number = int.Parse(str);

                    numbers.Add(number);

                }
                catch (FormatException)
                {

                    Console.WriteLine($" Unable to parse: '{c}'");



                }
                
            }
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }


        }
    }
}
