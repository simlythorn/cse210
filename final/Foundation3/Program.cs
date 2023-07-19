
/*using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Blue Sky Beauty Event!");
        Console.WriteLine(" ");
        List<Event> events = new List<Event>();

        // Pre-defined values for event details
        string[] titles = { "Lecture on Skincare", "Lecture on Makeup Techniques", "Lecture on Beauty Business", "Quit" };
        string[] descriptions = { "A lecture on the latest trends and techniques in skincare", "A lecture on the latest makeup techniques and products", "A lecture on the business of beauty and how to succeed in the industry" };
        string[] dates = { "2023-07-20", "2023-07-21", "2023-07-22" };
        string[] times = { "14:00", "15:00", "16:00" };
        string street = "123 Main St";
        string city = "Seattle";
        string state = "WA";
        string zipCode = "98101";
        string[] speakers = { "Jasmine May", "Jassy Joly", "Rihana Grande" };
        int[] capacities = { 100, 200, 300 };

        Address addresses = new Address(street, city, state, zipCode);

        while(true)
        {

            Console.WriteLine("Choose a lecture:");
            Console.WriteLine(" ");
            
            for (int i = 0; i < titles.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {titles[i]}");
            }
            Console.Write("Enter the number of choice: ");
            int lectureChoice = int.Parse(Console.ReadLine()) - 1;

            Lecture lectures = new Lecture(titles[lectureChoice], descriptions[lectureChoice], dates[lectureChoice], times[lectureChoice], addresses, speakers[lectureChoice], capacities[lectureChoice]);
            events.Add(lectures);
            Console.WriteLine(" ");
            Console.WriteLine(lectures.GetFullDetails());
            if (lectureChoice == 4)
            {
                break;
            }

        }
    }
}*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Blue Sky Beauty Event!");
        Console.WriteLine(" ");
        List<Event> events = new List<Event>();

        // Pre-defined values for event details
        string[] titles = { "Lecture on Skincare", "Lecture on Makeup Techniques", "Lecture on Beauty Business", "Quit" };
        string[] descriptions = { "A lecture on the latest trends and techniques in skincare", "A lecture on the latest makeup techniques and products", "A lecture on the business of beauty and how to succeed in the industry" };
        string[] dates = { "2023-07-20", "2023-07-21", "2023-07-22" };
        string[] times = { "14:00", "15:00", "16:00" };
        string street = "123 Main St";
        string city = "Seattle";
        string state = "WA";
        string zipCode = "98101";
        string[] speakers = { "Jasmine May", "Jassy Joly", "Rihana Grande" };
        int[] capacities = { 100, 200, 300 };

        Address addresses = new Address(street, city, state, zipCode);

        while(true)
        {
            Console.WriteLine("Choose a lecture:");
            Console.WriteLine(" ");
            
            for (int i = 0; i < titles.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {titles[i]}");
            }
            Console.Write("Enter the number of choice: ");
            int lectureChoice = int.Parse(Console.ReadLine()) - 1;

            if (lectureChoice == 3)
            {
                break;
            }
            
            Lecture lectures = new Lecture(titles[lectureChoice], descriptions[lectureChoice], dates[lectureChoice], times[lectureChoice], addresses, speakers[lectureChoice], capacities[lectureChoice]);
            events.Add(lectures);
            Console.WriteLine(" ");
            Console.WriteLine(lectures.GetFullDetails());
        }
    }
}


