using System.Security.Cryptography.X509Certificates;

namespace Packt.Shared;

public class Person
{
    public string? Name;
    public DateTimeOffset Born;
    public WondersOfTheAncientWords FavoriteAncientWonder;
    public WondersOfTheAncientWords BucketList;
    public List<Person> Children = new();
};
