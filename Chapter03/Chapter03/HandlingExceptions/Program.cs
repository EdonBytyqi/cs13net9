// See https://aka.ms/new-console-template for more information
using static System.Console;
using System.Text;
Console.WriteLine("Hello, World!");

WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine();

try
{
    int age = int.Parse(input);
    WriteLine($"You are {age} years old.");
}
catch (FormatException)
{
    WriteLine("The age you entered is not valid number format.");
    throw;
}
catch (OverflowException)
{
    WriteLine("Your age is a valid number format but it is either too big or too small.");
    throw;
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
    throw;
}
WriteLine("After parsing");

