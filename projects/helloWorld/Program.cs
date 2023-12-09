using System;
using System.Linq;

namespace HelloWorld  {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!!!"); //writing hello world
            Console.WriteLine("What is your Name?");
            string? name = Console.ReadLine();
            Console.WriteLine($"This is your Name: {name} or " + name);
            Console.WriteLine(string.Format("This is your Name: {0} {0} {1}", name, name + "a"));
            Console.WriteLine((DateTime.Now.Hour <= 18) ? "Good day." : "Good evening."); // writing good day when it is befor 18 o clock and good evening when it is after
            
            int[] myNumbers = {5, 1, 8, 9};
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
            
            int[,] numbers = { {1, 4, 2}, {3, 6, 8} }; //2D Array
            Console.WriteLine(numbers[0, 2]);  // Outputs 2

            foreach (int z in myNumbers) {
                Console.WriteLine("n" + z);
            }

            //isVowel is an bool
            //Console.WriteLine(isVowel ? "Vowel" : "Consonant");
            
        }
    }
}