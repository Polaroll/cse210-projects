using System;

class Program
{
    static void Main(string[] args)
    {
        // I like using spacers in the console to make it easier to read.
        Console.WriteLine("");

        Job job1 = new Job();
        job1._jobTitle = "Floor Associate";
        job1._company = "Lowes";
        job1._startYear = "2019";
        job1._endYear = "2019";
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Maintenance";
        job2._company = "Aspen Creek Senior Living";
        job2._startYear = "2022";
        job2._endYear = "2023";
        job2.Display();

        Console.WriteLine("");

        Resume resume1 = new Resume();
        resume1._name = "Ethan Houser";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

        Console.WriteLine("");


    }
}