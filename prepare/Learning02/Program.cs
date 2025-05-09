using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Waffle house";
        job1._jobTitle = "Grill operator";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Lockheed Martin";
        job2._jobTitle = "Electrical Engineer";
        job2._startYear = 2024;
        job2._endYear = 2050;

        Resume myResume = new Resume();
        myResume._name = "DJoshua Sanders";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.printResume();
    }
}