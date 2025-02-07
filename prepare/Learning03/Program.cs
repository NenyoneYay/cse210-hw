using System;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] args)
    {
        Fraction F1 = new Fraction(5,7);
        double myDouble = F1.getDecimalValue();
        string myFraction = F1.getFraction();
        Console.WriteLine(myFraction);
        Console.WriteLine(myDouble);
    }
}