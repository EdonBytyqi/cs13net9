namespace Packt.Shared;

public partial class Person
{
    public string? FavoriteIceCream { get; set; }
    private string? _favoritePrimaryColor;
    private WondersOfTheAncientWorld _favoriteAncientWonder;
    #region Properties: Methods to get and/or set data or state
    //A readonly property defined using C# 1 to 5 syntax
    public string Origin
    {
        get
        {
            return string.Format("{0} was born on {1}). ",
                arg0: Name,
                arg1: HomePlanet
            );
        }
    }

    //Two readonly properties defined using C# 6 or later
    //Lambda expression body syntax.

    public string Greeting => $"{Name} says 'Hello!'";
    public int Age => DateTime.Today.Year - Born.Year;

    //A public property to read and write to the field
    public string? FavoritePrimaryColor
    {
        get
        {
            return _favoritePrimaryColor;
        }
        set
        {
            switch (value?.ToLower())
            {
                case "red":
                case "green":
                case "blue":
                    _favoritePrimaryColor = value;
                    break;
                default:
                    throw new ArgumentException(
                        $"{value} is not primary color. " +
                        "Choose from: red, green, blue."
                    );
            }
        }
    }

    public WondersOfTheAncientWorld FavoriteAncientWonder
    {
        get { return _favoriteAncientWonder; }
        set
        {
            string wonderName = value.ToString();

            if (wonderName.Contains(','))
            {
                throw new ArgumentException(
                    message: "Favorite ancient wonder can only have a single enum value.",
                    paramName: nameof(FavoriteAncientWonder)

                );
            }
            if (!Enum.IsDefined(typeof(WondersOfTheAncientWorld), value))
            {
                throw new ArgumentException(
                    $"{value} is not a member of the WondersOfTheAncientWorld enum.",
                    paramName: nameof(FavoriteAncientWonder)

                );
            }

            _favoriteAncientWonder = value;
        }
    }
    #endregion
}