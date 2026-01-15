// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using static System.Console;




int x = 0;
while (x < 10)
{
    WriteLine($"While Loop: x = {x}");
    x++;
}

/* string? actualPassword = "Pa$$w0rd";
string? password;
int attempts = 0;
const int maxAttempts = 3;
do
{
    Write("Enter your password: ");
    password = Console.ReadLine();
    attempts++;
} while (password != actualPassword && attempts < maxAttempts);
if (password == actualPassword)
{
    WriteLine("Access granted.");
}
else
{
    WriteLine("Too many failed attempts.");
}*/

string[] fruits = { "Apple", "Banana", "Cherry" };
foreach (string fruit in fruits)
{
    WriteLine($"Fruit: {fruit} has {fruit.Length} characters.");
}
