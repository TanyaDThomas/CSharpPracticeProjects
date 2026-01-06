using System;

namespace Calculator;

public class Calculator
{


    public Calculator()
    {
        
    }

    public static int GetFirstNumber()
    {
        Console.WriteLine("Enter first number:");
        int a = Convert.ToInt32(Console.ReadLine());
        return a;
    }

     public static int GetSecondNumber()
    {
        Console.WriteLine("Enter second number:");
        int b = Convert.ToInt32(Console.ReadLine());
        return b;
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

     public static int Multiply(int a, int b)
    {
        return a * b;
    }
     public static int Divide(int a, int b)
    {
        return a / b;
    }

    public static double Power(double a, double b)
    {
        return Math.Pow(a,b);
    }

    public static double SquareRoot(double a)
    {
        return Math.Sqrt(a);
    }
}
