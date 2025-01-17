using System;
using System.Numerics;

class Program
{

    static void display_welcome(){
        Console.WriteLine("Welcome to the Program!");
    }
    static string prompt_user_name(){
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int prompt_user_number(){
        Console.WriteLine("Please enter your favorite number");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int square_number(int integer){
        int numberSquared = integer*integer;
        return numberSquared;
    }
    static void display_result(string userName, int numberSquared){
        Console.WriteLine (userName + ", the square of your number is "+ numberSquared);
    }

    static void Main(string[] args)
    {
        display_welcome();
        string userName = prompt_user_name();
        int userNumber = prompt_user_number();
        int numberSquared = square_number(userNumber);
        display_result(userName, numberSquared);
    }
}