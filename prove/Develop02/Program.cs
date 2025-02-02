using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    public static void Main_Menu(){
            var random = new Random();
            Console.WriteLine("Your Journal: What would you like to do?\nWRITE\nDISPLAY\nLOAD\nSAVE\nQUIT");
            string menuChoice = Console.ReadLine().ToLower();
            Console.WriteLine("You chose: " + menuChoice);


            if (menuChoice == "write"){
                Entry.Written_Entry(Entry._prompts[random.Next(0, Entry._prompts.Count)]);
                Main_Menu();
            }


            else if (menuChoice == "display"){
                foreach(string journalPage in Entry._page){
                    Console.WriteLine(journalPage);
                }
                Main_Menu();
            }


            else if (menuChoice == "load"){
                Console.WriteLine("Please type the name of the file you would like to load");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                foreach(string line in lines){
                    //string[] parts = line.Split("|");
                    Entry._page.Add(line);
                }
                Main_Menu();
            }


            else if (menuChoice == "save"){
                Console.WriteLine("Please name the file");
                string fileName = Console.ReadLine();
                using (StreamWriter OutputFile = new StreamWriter(fileName)){
                    if (Entry._page.Count > 0){
                        foreach(string journalPage in Entry._page){
                            OutputFile.WriteLine(journalPage);
                        }
                    } else{
                        Console.WriteLine("You don't have any entries to save right now!");
                    }
                }
                Main_Menu();
            }


            else if (menuChoice == "quit"){
                Console.WriteLine("Goodbye.");
                return;
            }


            else{
                Console.WriteLine("Input not recognized.");
                Main_Menu();
            }
        }
    static void Main(string[] args)
    {
        Main_Menu();
    }
}