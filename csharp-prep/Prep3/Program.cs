using System;

class Program
{
    static void Main(string[] args)
    {
        bool guessedCorrect = false;
        int guessAttempts = 0;



        Console.WriteLine("Welcome to the magic number game! Please select a number.");
        int magicNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Your Magic Number is " + magicNumber);
        Random r = new Random();
        int randomNumber = r.Next(0, magicNumber);


        Console.WriteLine("Guess a number.");
        int userNumber = int.Parse(Console.ReadLine());
        do{
            
            if (userNumber == randomNumber){
                Console.WriteLine("Congratulations! You guessed the magic number! What a fun game this was.");
                guessAttempts ++;
                guessedCorrect = true;
            }
            else if (userNumber > randomNumber){
                Console.WriteLine("Sorry! The number is lower than "+userNumber);
                guessAttempts ++;
                Console.WriteLine("Guess a number");
                userNumber = int.Parse(Console.ReadLine());
            }
            else if (userNumber < randomNumber){
                Console.WriteLine("Sorry! The number is higher than "+userNumber);
                guessAttempts ++;
                Console.WriteLine("Guess a number");
                userNumber = int.Parse(Console.ReadLine());
            }


        }while(guessedCorrect == false);
        Console.WriteLine("You guessed " + guessAttempts + " times");
    }
}