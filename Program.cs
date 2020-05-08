using System;
using System.IO;

namespace C__weekend_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Prompt: Please Enter a File Name:");
            string fileName = Console.ReadLine();
            File.WriteAllText(fileName, "this is your new file");
            Console.WriteLine("your file name: " + fileName);


            Console.WriteLine("Enter a string:");
            string myString = Console.ReadLine();

            string[] myStringArray = myString.Split(" ");
            foreach (string element in myStringArray)
            {
                File.WriteAllText(fileName, element);
                Console.WriteLine(element);

            }

            int option = 1;
            do {
              option++;
            } 

            while (option <= 3);      
            Console.WriteLine("Terminated"); 
             
        }
    }
}
