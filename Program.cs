using System;
using System.Linq;
using System.IO;

namespace C__weekend_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Prompt: Please Enter File Name:"); 
            string fileName = Console.ReadLine();
            File.WriteAllText(fileName, "you are inside" + " " + fileName ); 
            Console.WriteLine("your file name: " + fileName);

           
          
             
        }
    }
}
