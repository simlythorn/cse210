using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fraction1 = new Fraction(1, 1);
        Console.WriteLine(fraction1.GetFractionalView());
        Console.WriteLine(fraction1.GetDecimalView());

        Fraction fraction2 = new Fraction(5, 1);
        Console.WriteLine(fraction2.GetFractionalView());
        Console.WriteLine(fraction2.GetDecimalView());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionalView());
        Console.WriteLine(fraction3.GetDecimalView());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionalView());
        Console.WriteLine(fraction4.GetDecimalView());
    }
}