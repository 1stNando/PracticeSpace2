using System;
using System.Linq;
using System.Collections.Generic;
namespace PracticeSpace2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
            //Practicing LINQ's SELECT method. and String.Join
            var scores = new List<int> { 42, 100, 98, 15 };
            var newScores = scores.Select(score => score * 2);
            Console.WriteLine(String.Join(',', newScores));

            var slightlyBetterScores = scores.Select(score => score + 1);
            Console.WriteLine(String.Join(',', slightlyBetterScores));

            //Next method to write shorter lines of code to again multiply the items. Using Functions!!!
            //It will be a double-Errf function
            Func<int, int> MultiplyBy2 = score => score * 2;
            //Now make list that goes through the 'scores'
            //list, and for each item, call the 'MultiplyBy2' expression on that item and using the new value to put into a new list.
            //THIS IS GREAT because we can treat the function MultiplyBy2 as a variable type of method that can be reused. And we are putting it into the LINQ list.Select(functional method); ||| style.\
            var newScores2 = scores.Select(MultiplyBy2);
            //then print out the scores with comma separating them
            Console.WriteLine("Here is with Function used.");
            Console.WriteLine(String.Join(',', newScores2));

            //Example of calling a method Reverse() that sits outside of the Main() block, but shares the same Class space.
            string value = "Microsoft Learn";
            string reversedValue = Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");


        }
        //This builds a method that grabs a string of words and reverses the string order! Since the Reverse() method is defined in the same class, the code that calls the method doesn't need to qualify the method's name with the class name.
        static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }






    }
}
