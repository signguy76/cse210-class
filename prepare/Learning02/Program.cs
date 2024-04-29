using System;
using System.ComponentModel.DataAnnotations;



class Program
{
    static void Main(string[] args)
    {
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

        job1.Display();
        job2.Display();


        //Console.ReadLine();
    }
    public class Job
    {
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear; 

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }
}