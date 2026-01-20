using Packt.Shared;

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
#endregion


