using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGradeA = "A";
        string letterGradeB = "B";
        string letterGradeC = "C";
        string letterGradeD = "D";
        string letterGradeF = "F";

        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Hello user! Please enter your grade percentage.");
        string userGrade = Console.ReadLine();
        int userGradeInt = int.Parse(userGrade);
        if (userGradeInt > 100){
            Console.WriteLine("Wow, you have higher than 100%! That is an A with extra credit!");
        }
        else if ((userGradeInt >= 90) && (userGradeInt < 100)){
            Console.WriteLine ($"Your grade is {letterGradeA}");
        }
        else if ((userGradeInt >= 80) && (userGradeInt < 90)){
            Console.WriteLine ($"Your grade is {letterGradeB}");
        }
        else if ((userGradeInt >= 70) && (userGradeInt < 80)){
            Console.WriteLine ($"Your grade is {letterGradeC}");
        }
        else if ((userGradeInt >= 60) && (userGradeInt < 70)){
            Console.WriteLine($"Your grade is {letterGradeD}");
        }
        else{
            Console.WriteLine($"Your grade is {letterGradeF}");
        }

        if ((userGradeInt >= 70) && (userGradeInt < 90)){
            Console.WriteLine($"Congratulations, you are passing! You need {90 - userGradeInt} more points to get an A!");
        }
        else if (userGradeInt >= 90){
            Console.WriteLine($"Congratulations, you are passing!");
        }
        else if (userGradeInt < 70){
            Console.WriteLine ($"Uh oh! You are failing the class! You need {70-userGradeInt} more points to start passing this class!");
        }
    }
}