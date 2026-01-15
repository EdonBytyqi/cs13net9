// See https://aka.ms/new-console-template for more information
using static System.Convert;
Console.WriteLine("Hello, World!");

int a = 10;
double b = a; // Implicit conversion from int to double
Console.WriteLine($"Implicit conversion: int {a} to double {b}");

double c = 9.78;
int d = (int)c; // Explicit conversion from double to int
Console.WriteLine($"Explicit conversion: double {c} to int {d}");

long e = 10;
int f = (int)e; // Explicit conversion from long to int
Console.WriteLine($"Explicit conversion: long {e} to int {f}");

e = long.MaxValue;
f = (int)e; // Explicit conversion from long to int, may cause data loss
Console.WriteLine($"Explicit conversion with potential data loss: long {e} to int {f}");

double g = 123.45;
int h = ToInt32(g); // Using Convert class to convert double to int
Console.WriteLine($"Using Convert class: double {g} to int {h}");