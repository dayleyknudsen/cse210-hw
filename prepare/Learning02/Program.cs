using System;

class Program
{
    static void Main(string[] args)
    {
          Job job1 = new Job();
        job1._jobTitle = "Software Development";
        job1._company = "Pathway";
        job1._startYear = 2020;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Apprentice";
        job2._company = "Tree";
        job2._startYear = 2012;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Dayley Knudsen";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}