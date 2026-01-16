// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string fizz = "Fizz";
string buzz = "Buzz";

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(fizz + buzz);
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(fizz);
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(buzz);
    }
    else
    {
        Console.WriteLine(i);
    }
}

int x = 3;
int y = x++;
Console.WriteLine($"x: {x}, y: {y}"); // x: 4, y: 3

int z = y;
Console.WriteLine($"z: {z}"); // z: 3