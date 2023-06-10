using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
         int inputnumber = -1;
        do
        {
            Console.Write("Enter number: ");
            inputnumber = int.Parse(Console.ReadLine());
            if (inputnumber != 0)
            {
            numbers.Add(inputnumber);
            }
       
        } while (inputnumber != 0);

        int Sum = 0;
        foreach ( int number in numbers)
        { 
            Sum += number;
        }
        Console.WriteLine($"The Sum: {Sum}"); 

        float Average = 0;
        int max = numbers[0];
        int min = numbers[0];
        for (int i = 0; i < numbers.Count; i++)
        {
            Average = ((float)Sum / numbers.Count);
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        int SmallestPositive = numbers.Where(number => number > 0).Min();
        int SmallestNegative = numbers.Where(number => number < 0).Max();
        int largeNumber = numbers.Where(number => number > 0).Max();
        int smallNumber = numbers.Where(number => number < 0).Min();

        Console.WriteLine($"The Average: {Average.ToString("0.00")}"); 
        Console.WriteLine($"The Large Number: {max}");
        Console.WriteLine($"The small nuumber: {min}");
        Console.WriteLine($"The Positive small nuumber: {SmallestPositive}");
        Console.WriteLine($"The Negative small nuumber: {SmallestNegative}"); 
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach ( int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

}