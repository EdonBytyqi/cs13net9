// See https://aka.ms/new-console-template for more information
using static System.Console;

string password = "secret";

if (password.Length < 8)
{
    Console.WriteLine("Password is too short.");
}
else if (password.Length > 16)
{
    Console.WriteLine("Password is too long.");
}
else
{
    Console.WriteLine("Password length is just right.");
}


int number = Random.Shared.Next(minValue: 1, maxValue: 7);
WriteLine($"Number: {number}");

switch (number)
{
    case 1:
        WriteLine("One");
        break;
    case 2:
        WriteLine("Two");
        break;
    case 3:
        WriteLine("Three");
        break;
    case 4:
        WriteLine("Four");
        break;
    case 5:
        WriteLine("Five");
        break;
    case 6:
        WriteLine("Six");
        break;
    default:
        WriteLine("Number is out of range.");
        break;
}

var animals = new Animal?[]
{
    new Cat { Name = "Whiskers", Born = DateTime.Now, Legs = 4, IsDomestic = true },
    new Spider { Name = "Charlotte", Born = DateTime.Now, Legs = 8, IsVenomous = false },
    new Cat { Name = "Tom", Born = DateTime.Now, Legs = 4, IsDomestic = false },
    null
};

foreach (Animal? animal in animals)
{
    string message;

    switch (animal)
    {
        case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
            message = $"This is a cat named {fourLeggedCat.Name} with 4 legs.";
            break;
        case Cat wildCat when wildCat.IsDomestic == false:
            message = $"This is a wild cat named {wildCat.Name}.";
            break;
        case Cat cat:
            message = $"This is a domestic cat named {cat.Name}.";
            break;
        default:
            message = $"{animal.Name} is a {animal?.GetType().Name}.";
            break;
        case Spider spider when spider.IsVenomous:
            message = $"This is a venomous spider named {spider.Name}.";
            break;
        case null:
            message = "This animal is null.";
            break;
    }
    WriteLine($"switch message: {message}");
}

var animals2 = new Animal?[]
{
    new Cat { Name = "Whiskers", Born = DateTime.Now, Legs = 4, IsDomestic = true },
    new Spider { Name = "Charlotte", Born = DateTime.Now, Legs = 8, IsVenomous = false },
    new Cat { Name = "Tom", Born = DateTime.Now, Legs = 4, IsDomestic = false },
    null
};

foreach (Animal? animal in animals2)
{
    string messageTwo = animal switch
    {
        Cat fourLeggedCat when fourLeggedCat.Legs == 4
            => $"This is a cat named {fourLeggedCat.Name} with 4 legs.",

        Cat wildCat when wildCat.IsDomestic == false
            => $"This is a wild cat named {wildCat.Name}.",

        Cat cat
            => $"This is a domestic cat named {cat.Name}.",

        Spider spider when spider.IsVenomous
            => $"This is a venomous spider named {spider.Name}.",

        Animal a
            => $"{a.Name} is a {a.GetType().Name}.",

        null
            => "This animal is null."
    };

    WriteLine($"switch expression message: {messageTwo}");
}
