using System;
// Namespace
namespace CsApp{
    // Main class
    class Program{
        // Entry point Method
        static string message;
        static void Main(string[] args){
            
            GetAppInfo();
            // Ask Users Name
            GreetUser();
            while(true){

                // int correctNumber = 7;
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                int guess = 0;

                while (guess != correctNumber){
                    string inputString = Console.ReadLine();

                    // Ensure that it's number
                    if (!int.TryParse(inputString, out guess)){
                        message ="Please use an actual number";
                        PrintColorMessage(ConsoleColor.DarkRed, message);
                        continue;
                    }
                    // Cast to int and put in guess
                    guess = Int32.Parse(inputString);
                    if (guess != correctNumber){
                        message = "Incorrect Number";
                        PrintColorMessage(ConsoleColor.Red, message);
                        continue;

                    }
                    message = "You are correct";
                    PrintColorMessage(ConsoleColor.Yellow, message);

                    // Ask to play again
                    Console.WriteLine("Play again?  [Y or N] ");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y"){
                        continue;
                    }
                    else if (answer == "N"){
                        return;
                    }
                    else{
                        Console.WriteLine("Please write Y or N");
                    }
                }
            }
        }//main 

        static void GetAppInfo(){
            String Name = "CsAPP";
            String Version = "1.0.0";
            String Author = "Jay C";
            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            // App info
            Console.WriteLine("{0}: Version {1} by {2}", Name, Version, Author);
            Console.ResetColor(); //uncomment line to reset color

        }// GetAppInfo
        static void GreetUser(){
            Console.WriteLine("What is Your name?");
            String input = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...\n Please Guess a number", input);
        }// GreetUser
        static void PrintColorMessage(ConsoleColor color, string message ){

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor(); //reset color
        }//PrintColorMessage
    }
}
