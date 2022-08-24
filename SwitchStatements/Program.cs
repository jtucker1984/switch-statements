using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your favorite subject?");


            string favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "biology":
                    Console.WriteLine("biology is a hard one");
                    break;
             
                case "science":
                    Console.WriteLine("Science! THats a great subject.");
                    break;
                case "english":
                    Console.WriteLine("English was cool I guess");
                    break;
                case "history":
                    Console.WriteLine("History is fun");
                    break;
                case "math":
                    Console.WriteLine("I hated math");
                    break;
                case "coding":
                    Console.WriteLine("Really? I go to True Coders");
                    break;
                default:
                    Console.WriteLine("you must be a genius");
                    break;
               


        }    }
            
    }
}

