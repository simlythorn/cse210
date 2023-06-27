using System;
namespace Library_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment = new Assignment ("Samuel Bennett", "Multiplication");
            Console.WriteLine(assignment.GetSummary());
            

            MathAssignment assignment1 = new MathAssignment("Simly", "Math", "Section 7.1", "problem 5-6");
            assignment1.GetHomeworkList();
            assignment1.GetSummary();
            Console.WriteLine(assignment1.GetSummary());
            Console.WriteLine(assignment1.GetHomeworkList());
            

            WritingAssignment assignment2 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II"); 
            assignment2.GetSummary();
            assignment2.GetWritingInformation();
            Console.WriteLine(assignment2.GetSummary());
            Console.WriteLine(assignment2.GetWritingInformation());

        

        }
    }
}

