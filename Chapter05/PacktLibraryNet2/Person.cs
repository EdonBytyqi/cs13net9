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
};
