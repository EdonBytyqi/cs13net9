// See https://aka.ms/new-console-template for more information
using static System.Console;
using System.Globalization;

Console.WriteLine("Hello, World!");

byte[] binaryObject = new byte[128];

Random.Shared.NextBytes(binaryObject);

WriteLine("Binary Object as byte array:");
for (int index = 0; index < binaryObject.Length; index++)
{
    Write($"{binaryObject[index]:X2} ");
}
Console.WriteLine();

string encoded = Convert.ToBase64String(binaryObject);
Console.WriteLine($"Binary Object as Base64 String: {encoded}");

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

int friends = int.Parse("27");
DateTime birthday = DateTime.Parse("4 July 1980");
WriteLine($"I have {friends} to invite to my party.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.");

Write("How many eggs are there? ");
string? input = ReadLine();

if (int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse the input.");
}

int number = int.Parse("123");
bool success = int.TryParse("123", out int number);

bool success = Uri.TryCreate("https://localhost:5000/api/customers",
    UriKind.Absolute, out Uri serviceUrl);