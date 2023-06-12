using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Cyber Security";
        job1._company = "Meta";
        job1._startYear = 2027;
        job1._endYear = 2057;
        //Console.WriteLine($"{job1._jobTitle} ,{job1._company}");
        
    // create second job2
        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Amazon";
        job2._startYear = 2024;
        job2._endYear = 2050;
        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Simly Thorn";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();
        

    }
}


