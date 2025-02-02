using System;


public class Entry{
    public static List<string> _prompts = new List<string>{
        "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?", 
        "If I had one thing I could do over today, what would it be?",
        "Who was the most interesting person I interacted with today?"
    };
    public static List<string> _page = new List<string>{};
    public static string Written_Entry(string prompt){
        Console.WriteLine(prompt);
        string userInput = Console.ReadLine();
        Entry._page.Add($"{DateTime.Now.ToString("yyyy-MM-dd")} {prompt} {userInput}");
        return "temporary";

    }
}


// 
// 
// 
// 