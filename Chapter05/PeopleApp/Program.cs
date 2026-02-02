using Packt.Shared;
using Fruit = (string Name, int Number); //Aliasing a tuple


ConfigureConsole();

Person bob = new();
WriteLine(bob);

/* Book book = new()
{
  Isbn = "0-123456-78-9",
  Title = "The Art of C#"
};*/

Book book = new(isbn: "1231-12313", title: "C# baba")
{
  Author = "Mark J. Price",
  PageCount = 1000
};

Person sam = new()
{
  Name = "Sam",
  Born = new(1969, 6, 25, 0, 0, 0, TimeSpan.Zero)
};



#region Setting and outputting field values

bob.Name = "Bob Smith";

bob.Born = new DateTimeOffset(
  year: 1965, month: 12, day: 22,
  hour: 16, minute: 28, second: 0,
  offset: TimeSpan.FromHours(-5)); // US Eastern Standard Time.

WriteLine(format: "{0} was born on {1:D}.", // Long date.
  arg0: bob.Name, arg1: bob.Born);

Person alice = new()
{
  Name = "Alice Jones",
  Born = new DateTimeOffset(
      year: 1998, month: 3, day: 7,
      hour: 11, minute: 23, second: 0,
      offset: TimeSpan.FromHours(1)) // Central European Standard Time.
};

WriteLine(format: "{0} was born on {1:D}.", // Long date.
  arg0: alice.Name, arg1: alice.Born);

#endregion

#region Favorite ancient wonder
bob.FavoriteAncientWonder = WondersOfTheAncientWorlds.StatueOfZeusAtOlympia;
WriteLine(
  format: "{0}'s favorite ancient wonder is {1}. Its integer is {2}.",
  arg0: bob.Name,
  arg1: bob.FavoriteAncientWonder,
  arg2: (int)bob.FavoriteAncientWonder
);

bob.BucketList =
  WondersOfTheAncientWorlds.HangingGardensOfBabylon
  | WondersOfTheAncientWorlds.MausoleumAtHalicarnassus;
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");
#endregion

#region Children
bob.Children.Add(alice);
bob.Children.Add(new Person { Name = "Charlie Smith" });
bob.Children.Add(new Person { Name = "Daisy Smith" });

WriteLine($"{bob.Name} has {bob.Children.Count} child(ren).");
for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
  WriteLine($"> {bob.Children[childIndex].Name}");
}
#endregion

#region BankAccount
BankAccount.InterestRate = 0.012M; // 1.2%

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs.Jones";
jonesAccount.Balance = 2400;
WriteLine(
  format: "{0} earned {1:C} interest.",
  arg0: jonesAccount.AccountName,
  arg1: jonesAccount.Balance * BankAccount.InterestRate
);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms.Gerrier";
gerrierAccount.Balance = 98;
WriteLine(
  format: "{0} earned {1:C} interest.",
  arg0: gerrierAccount.AccountName,
  arg1: gerrierAccount.Balance * BankAccount.InterestRate
);
#endregion
#region const fields
WriteLine($"{bob.Name} is a {Person.Species}.");
#endregion
#region readonly fields
// readonly field can be changed in constructor, but not here
WriteLine($"{bob.Name} lives on {bob.HomePlanet}.");
#endregion

#region Initializing fields with constructors

Person blankPerson = new();

WriteLine(format:
  "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
  arg0: blankPerson.Name,
  arg1: blankPerson.HomePlanet,
  arg2: blankPerson.Instantiated);

Person gunny = new(
  initialName: "Gunny",
  homePlanet: "Mars");

WriteLine(format:
  "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
  arg0: gunny.Name,
  arg1: gunny.HomePlanet,
  arg2: gunny.Instantiated);
#endregion
#region Methods
bob.WriteToConsole();
WriteLine(bob.GetOrigin());
WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));
WriteLine(bob.OptionalParameters(command: "Stop!", number: 2.3, count: 3));
WriteLine(bob.OptionalParameters(command: "Stop!", number: 2.3, count: 3));
WriteLine(bob.OptionalParameters(number: 3.4, command: "Go!", count: 3));
#endregion

#region Parameters
int a = 10;
int b = 20;
int c = 30;
int d = 40;
int e = 50;
int f = 60;
int g = 70;

WriteLine($"Before: a={a},b={b},c={c},d={d}");
WriteLine($"Before: e={e},f={f},g={g}, he doesnt exist yet!");

bob.PassingParameters(a, b, ref c, out d);
WriteLine($"After: a={a},b={b},c={c},d={d}");

// Simplified C# 7 or later syntax for the out parameter
bob.PassingParameters(e, f, ref g, out int h);
WriteLine($"After: e={e},f={f},g={g},h={h}");

bob.ParamsParameters("Sum using commas", 3, 6, 1, 2);
bob.ParamsParameters("Sum using collection expression", 3, 6, 1, 2);
bob.ParamsParameters("Sum using explicit array", 3, 6, 1, 2);
bob.ParamsParameters("Sum (empty)");
#endregion

#region Tuples
(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children");

var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children");

Fruit fruitNameObj = bob.GetFruit();
//Deconstructing tuples
(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"Deconstructed tuple: {fruitName}, {fruitNumber}");

var (name1, dob1) = bob; //Implicity calls the Deconstruct method
WriteLine($"Deconstructed person: {name1}, {dob1}");

var (name2, dob2, fav2) = bob; //Implicity calls the Deconstruct method
WriteLine($"Deconstructed person: {name2}, {dob2}, {fav2}");
#endregion

#region Local Functions
// Change to -1 to make the exception handling code execute
int number = 5;

try
{
  WriteLine($"{number}! is {Person.Factorial(number)}");
}
catch (Exception ex)
{
  WriteLine($"{ex.GetType()} says: {ex.Message} number was {number}");
}
#endregion

#region Properties
WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");

string color = "Red";

try
{
  sam.FavoritePrimaryColor = color;
  WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}");
}
catch (Exception ex)
{
  WriteLine($"Tried to set {nameof(sam.FavoritePrimaryColor)} to '{color}' : {ex.Message}");
}

#endregion

#region indexers
sam.Children.Add(new()
{
  Name = "Charlie",
  Born = new(2010, 3, 18, 0, 0, 0, TimeSpan.Zero)
});
sam.Children.Add(new()
{
  Name = "Ella",
  Born = new(2020, 12, 24, 0, 0, 0, TimeSpan.Zero)
});
//Get using Children list
WriteLine($"Sams first child is {sam.Children[0].Name}");
WriteLine($"Sams second child is {sam.Children[1].Name}");
//Get using the int indexer
WriteLine($"Sams first child is {sam[0].Name}");
WriteLine($"Sams second child is {sam[1].Name}");
//Get using the string indexer
WriteLine($"Sams child named Ella is {sam["Ella"].Age} years old.");
#endregion

#region pattern matching
//An array contaning a mix of passenger types
Passenger[] passengers =
{
  new FirstClassPassenger {AirMiles = 1_419, Name = "Suman"},
  new FirstClassPassenger {AirMiles = 16_562, Name = "Lucy"},
  new BusinessClassPassenger { Name = "Janice"},
  new CoachClassPassenger {CarryOnKG = 25.7, Name = "Dave"},
  new CoachClassPassenger {CarryOnKG = 0, Name = "Amit"},
};

foreach (Passenger passenger in passengers)
{
  decimal flightCost = passenger switch
  {
    /* C# 8 Syntax FirstClassPassenger p when p.AirMiles > 35_000 => 1_500M,
    FirstClassPassenger p when p.AirMiles > 15_000 => 1_750M,
    FirstClassPassenger _ => 2_000M, */
    // C# 9 or later syntax
    FirstClassPassenger p => p.AirMiles switch
    {
      > 35_000 => 1_500M,
      > 15_000 => 1_750M,
      _ => 2_000M
    },
    BusinessClassPassenger _ => 2_000M,
    CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
    CoachClassPassenger _ => 650M,
    _ => 800M,
  };
  WriteLine($"Flight costs {flightCost: C} for {passenger}");
}
#endregion

#region working with record types
ImmutablePerson jeff = new()
{
  FirstName = "Jeff",
  LastName = "Winger"
};
// jeff.FirstName = "Geoff"; // Cannot assign to init-only property after initialization

ImmutableVehicle car = new()
{
  Brand = "Mazda MX-5 RF",
  Color = "Sould Red Crystal Metallic",
  Wheels = 4
};

ImmutableVehicle repaintedCar = car with { Color = "Polymetal Grey Metallic" };
WriteLine($"Original car color was {car.Color}");
WriteLine($"New car color is {repaintedCar.Color}");

AnimalClass ac1 = new() { Name = "Rex" };
AnimalClass ac2 = new() { Name = "Rex" };
WriteLine($"ac1 == ac2: {ac1 == ac2}");

AnimalRecord ar1 = new() { Name = "Rex" };
AnimalRecord ar2 = new() { Name = "Rex" };
WriteLine($"ar1 == ar2: {ar1 == ar2}");

int number1 = 3;
int number2 = 3;
WriteLine($"number1: {number1}, number2: {number2}");
WriteLine($"number1 == number2: {number1 == number2}");
#endregion
