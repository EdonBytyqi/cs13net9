// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Exploring unary operators

int a = 3;
int b = a++;
Console.WriteLine($"a: {a}, b: {b}"); // a: 4, b: 3
int c = 3;
int d = ++c;
Console.WriteLine($"c: {c}, d: {d}"); // c: 4, d: 4
#endregion

#region Exploring binary operators
int e = 10;
int f = 3;
int sum = e + f;
int difference = e - f;
int product = e * f;
double quotient = (double)e / f;
int remainder = e % f;
WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Remainder: {remainder}");
#endregion

#region Assignment operators
int g = 5;
g += 3; // g = g + 3
WriteLine($"g after += 3: {g}");
g *= 2; // g = g * 2
WriteLine($"g after *= 2: {g}");
#endregion

#region Null-coalescing operator
string? nullableString = null;
string nonNullableString = nullableString ?? "Default Value";
WriteLine($"nonNullableString: {nonNullableString}");
#endregion 

static bool DoStuff()
{
    WriteLine("Doing stuff...");
    return true;
}