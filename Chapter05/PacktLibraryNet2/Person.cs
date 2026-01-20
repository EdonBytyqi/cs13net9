using System.Security.Cryptography.X509Certificates;

namespace Packt.Shared;

public class Person
{
    #region  Fields
    public string? Name;
    public DateTimeOffset Born;
    public WondersOfTheAncientWords FavoriteAncientWonder;
    public WondersOfTheAncientWords BucketList;
    public List<Person> Children = new();
    public const string Species = "Homo sapiens";

    // Readonly fields: Vaues that can be set at runtime
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    #endregion

    #region Constructors: Called when using new to instatiate a type.
    public Person()
    {
        // Constructors can set default values for fields
        // including any read-only fields like Instantiated
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }
    #endregion

    #region Methods
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}";
    }

    public string SayHello()
    {
        return $"{Name} says 'Hello!'";
    }
    public string SayHello(string name)
    {
        return $"{Name} says 'Hello {name}!'";
    }

    public string OptionalParameters(string command = "Run!", double number = 0.0, bool active = true)
    {
        return string.Format(
            format: "command is {0}, number is {1}, active is {2}",
            arg0: command,
            arg1: number,
            arg2: active
        );
    }
    #endregion

};
