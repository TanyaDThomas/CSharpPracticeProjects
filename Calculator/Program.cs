

using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Net.Quic;


bool keepRunning = true;
List<string> results = new List<string>();

do
{

Console.WriteLine("What would you like to do?");
Console.WriteLine(" - Add");
Console.WriteLine(" - Subtract");
Console.WriteLine(" - Multiply");
Console.WriteLine(" - Divide");
Console.WriteLine(" - Power");
Console.WriteLine(" - Square Root");
Console.WriteLine(" - Quit");
Console.WriteLine(" - History");


string? input = Console.ReadLine();
string calculate = input.ToLower();

int a, b;


switch (calculate)
{
    case "add":
        a = Calculator.Calculator.GetFirstNumber();
        b = Calculator.Calculator.GetSecondNumber();
        int sum = Calculator.Calculator.Add(a, b);
        Console.WriteLine($"{a} + {b} = {sum}");
        results.Add($"{DateTime.Now}  {a} + {b} = {sum}");
        break;
    case "subtract":
        a = Calculator.Calculator.GetFirstNumber();
        b = Calculator.Calculator.GetSecondNumber();
        int difference = Calculator.Calculator.Subtract(a, b);
        Console.WriteLine($"{a} - {b} = {difference}");
        results.Add($"{DateTime.Now}  {a} - {b} = {difference}");
        break;
    case "multiply":
        a = Calculator.Calculator.GetFirstNumber();
        b = Calculator.Calculator.GetSecondNumber();
        int product = Calculator.Calculator.Multiply(a, b);
        Console.WriteLine($"{a} x {b} = {product}");
        results.Add($"{DateTime.Now}  {a} x {b} = {product}");
        break;
    case "divide":
        a = Calculator.Calculator.GetFirstNumber();
        b = Calculator.Calculator.GetSecondNumber();
        int quotient = Calculator.Calculator.Divide(a, b);
        Console.WriteLine($"{DateTime.Now}  {a} / {b} = {quotient}");
        results.Add($"{a} / {b} = {quotient}");
        break;  
    case "power":
        a = Calculator.Calculator.GetFirstNumber();
        b = Calculator.Calculator.GetSecondNumber();
        double powerOf = Calculator.Calculator.Power(a, b);
        Console.WriteLine($"{a} ^ {b} = {powerOf}");
        results.Add($"{DateTime.Now}  {a} ^ {b} = {powerOf}");
        break; 
    case "square root":
        a = Calculator.Calculator.GetFirstNumber();
        double squared = Calculator.Calculator.SquareRoot(a);
        Console.WriteLine($"\u221A{a} = {squared}");
        results.Add($"{DateTime.Now}  \u221A{a} = {squared}");
        break; 
    case "quit":
        keepRunning = false;
        break;
    case "history":
        foreach(var result in results)
            {
                Console.WriteLine(result);
            }
        break;    
    default:
        Console.WriteLine("Involid input");
        keepRunning = false;
        break;
}

if(!keepRunning)
    {
        break;
    }

}while (true);
