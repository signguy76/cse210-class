using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume();

        Job job1 = new Job();
        job1._company = "Crown Graphics";
        job1._jobTitle = "Installer";
        job1._startYear = 2024;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._company = "Sign Factory";
        job2._jobTitle = "Salesman";
        job2._startYear = 2024;
        job2._endYear = 2028;

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();


        //Console.ReadLine();
    }
}