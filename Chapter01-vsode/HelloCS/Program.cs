// See https://aka.ms/new-console-template for more information
string name = typeof(Program).Namespace ?? "<null>";
Console.WriteLine($"Namespace: {name}");
throw new Exception();
