using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Window Washer";
        job1._company = "Window CLeaning";
        job1._startYear = 2015;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Bay sitting";
        job2._company = "Stuff";
        job2._startYear = 2012;
        job2._endYear = 2015;

        Resume resume = new Resume();
        resume._name = "Sara Smith";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        Console.WriteLine($"Name: {resume._name}");
        Console.WriteLine($"Jobs: ");
        resume.Display();
    }
}