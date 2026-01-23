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
bob.FavoriteAncientWonder = WondersOfTheAncientWords.StatueOfZeusAtOlympia;
WriteLine(
  format: "{0}'s favorite ancient wonder is {1}. Its integer is {2}.",
  arg0: bob.Name,
  arg1: bob.FavoriteAncientWonder,
  arg2: (int)bob.FavoriteAncientWonder
);

bob.BucketList =
  WondersOfTheAncientWords.HangingGardensOfBabylon
  | WondersOfTheAncientWords.MausoleumAtHalicarnassus;
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


