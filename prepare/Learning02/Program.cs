using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2018;
        job1._endYear = 2022;

        Resume resume1 = new Resume();
        resume1._name = "Michael Loftus";
        resume1._jobs.Add(job1);
        resume1.Display();
    }
}