using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> newList = new List<int>();
        int userNumber;
        int newListSum = 0;
        int newListAverage;
        int newListMax;
        int newListSmallPos = 0;
        do{
            Console.WriteLine("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            newList.Add(userNumber);
            if (userNumber > 0){
                newListSmallPos = userNumber;
            }
        }while (userNumber != 0);

        newListMax = newList[0];
        for (int i = 0; i<newList.Count-1; i++){
            // Console.WriteLine(newList[i]);
            newListSum += newList[i];
            if (newList[i] >= newListMax){
                newListMax = newList[i];
            }
        }
            for (int i = 0; i<newList.Count-1;i++){
                if ((newList[i] < newListSmallPos) && (newList[i] > 0)){
                    newListSmallPos = newList[i];
                }
            }
        
        newListAverage = newListSum / (newList.Count-1);
        Console.WriteLine("The sum is: " + newListSum);
        Console.WriteLine("the average is: "+ newListAverage);
        Console.WriteLine("The highest number in the list is: "+ newListMax);
                
        if (newListSmallPos <= 0){
            Console.WriteLine("All numbers are 0 or less, there is no smallest positive number.");
        } else{
            Console.WriteLine("The smallest positive number is: " + newListSmallPos);
        }
    }
}
