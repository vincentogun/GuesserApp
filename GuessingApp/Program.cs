using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

//Namespace
namespace GuessingApp
{
    class Program //Main Class
    {
        //Entry Point
        static void Main(string[] args)
        {

            GetAppInfo(); //Run GetAppInfo to get Info

            GreetUser(); //Welcome User

            while (true) 
            { 

              //Set Correct number
              // int correctNumb = 7;

              //Init guess var
               int guess = 0;

              //Create a random Object
              Random random = new Random();
              int correctNumb = random.Next(1, 10);


              Console.WriteLine("Guess a new Number between 1 ans 10");


              //while guess is not correct
              while (guess != correctNumb)
              {
                string input = Console.ReadLine();


                //Make sure its a number
                if (!int.TryParse(input, out guess))
                {

                   PrintColorMessage(ConsoleColor.Red, "Please use an Actual Number");
                        
                    //keep going
                    continue;
                }

                //Cast to Int and put in guess
                guess = Int32.Parse(input);

                //match guess to Correct numb
                if (guess != correctNumb)
                {
                        //print Error Message
                   PrintColorMessage(ConsoleColor.Red, "Please Try Again");
                

                } 


              }
                 
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");


                //Ask to Play Again
                Console.WriteLine("Play Again? {YES or NO}");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "YES")
                {
                    continue;
                }
                else if(answer == "NO")
                {
                    return;
                }
                else
                {
                    return;
                }
                
            } 

            
        }

        static void GetAppInfo()
        {
            string appName = "Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Vince";

            //Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write Up App Info
            Console.WriteLine("{0}: Version {1} By {2}", appName, appVersion, appAuthor);

            //Reset Color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask User
            Console.WriteLine("What is your name??");

            //Get User Input
            string inputname = Console.ReadLine();

            Console.WriteLine(" "); 

            //Message
            Console.WriteLine($"Hello {inputname}, Lets play a Game...");

            Console.WriteLine(" ");
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //change text color
            Console.ForegroundColor = color;

            //Write Up App Info
            Console.WriteLine(message);

            Console.ResetColor();

        }
    }
}
