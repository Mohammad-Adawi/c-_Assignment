using System;
using System.IO;

namespace C__weekend_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            Console.WriteLine("Prompt: Please Enter a File Name:");
            string fileName = Console.ReadLine();
            while (option <3) {
                option++;
            if (option == 1) {
            File.WriteAllText(fileName, "this is your new file");
            Console.WriteLine("your file name: " + fileName);
            }
        if (option == 2) {
            Console.WriteLine("Enter a string:");
            string myString = Console.ReadLine();

            string[] myStringArray = myString.Split(" ");
            for (int pos = 0; pos < myStringArray.Length; pos++)
            {
                File.WriteAllText(fileName, myStringArray[pos]);
                Console.WriteLine(myStringArray[pos]);

            }
        }
      }
          
             if (option == 3)
            {
                Console.WriteLine("Program is Terminated");

                return;

            }
        }
    }
}
