using System;


namespace NumberGuess
{
    //main class
    class Program
    {
        //entry point method
        static void Main(string[] args)
        {
            GetappInfo();
            GreetUser();
            
            
            while (true)
            {
                //set correct number
                //int correctNumber = 7;

                //create new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                //init guess var
                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    //make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColourmsg(ConsoleColor.Red,"Please use a valid number");
                        //keep going
                        continue;
                    }
                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColourmsg(ConsoleColor.Red, "Wrong answer. Please try again");
                    }
                }
                //output success message
                PrintColourmsg(ConsoleColor.DarkYellow, "you are CORRECT!!!");

                //Ask to play again
                Console.WriteLine("Play Again? [Y/N]");
                //get answer
                string answer=Console.ReadLine().ToUpper();
                if(answer =="Y")
                {
                    continue;
                }
                else if( answer =="N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        static void GetappInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "avani";

            //change text colour
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //write app info
            Console.WriteLine("{0} :Version {1} by {2}", appName, appVersion, appAuthor);
            //reset text color
            Console.ResetColor();
        }
        static void GreetUser()
        {
            //ask user name
            Console.WriteLine("what is your name?");
            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0},lets paly a game..", inputName);

        }
        static void PrintColourmsg(ConsoleColor color,string message)
        {
            //change text color
            Console.ForegroundColor = color;

            //write error message
            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
