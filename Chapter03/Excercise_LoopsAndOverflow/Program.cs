// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int max = 500;

//for (byte i = 0; i <= max; i++)
//{
//    Console.WriteLine(i);
//}
// The above code will cause an infinite loop due to byte overflow.
// To fix this, we can change the loop variable to a larger data type like int.
for (int i = 0; i <= max; i++)
{
    Console.WriteLine(i);
}
