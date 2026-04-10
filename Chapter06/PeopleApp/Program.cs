using Packt.Shared;
#region PeopleApp
Person harry = new()
{
    Name = "Harry",
    Born = new(year: 2001, month: 3, day: 25,
        hour: 0, minute: 0, second: 0,
        offset: TimeSpan.Zero)
};

Person edon = new() { Name = "Edon" };
Person donjeta = new() { Name = "Donjeta" };
Person asddsa = new() { Name = "Asddsa" };

//call instance method to marry two persons
edon.Marry(donjeta);

//static method
edon.Marry(asddsa);

edon.OutputSpouses();
donjeta.OutputSpouses();
asddsa.OutputSpouses();

//call instance method to make a baby
Person baby1 = Person.Procreate(edon, donjeta);
baby1.Name = "Art";
WriteLine($"{baby1.Name} was born on {baby1.Born}");

Person baby2 = Person.Procreate(edon, asddsa);
baby2.Name = "Art";
WriteLine($"{baby2.Name} was born on {baby2.Born}");

edon.WriteChildrenToConsole();
donjeta.WriteChildrenToConsole();
asddsa.WriteChildrenToConsole();

for (int i = 0; i < edon.Children.Count; i++)
{
    WriteLine(format: "  {0}'s child #{1} is named \"{2}\".",
    arg0: edon.Name, arg1: i,
    arg2: edon.Children[i].Name);
}

harry.WriteToConsole();

if (edon + donjeta)
{
    WriteLine($"{edon.Name} and {donjeta.Name} successfully got married.");
}

Person baby3 = edon * donjeta;
baby3.Name = "ArtiBoi";
#endregion

#region non-generic types
System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2; //Look up the value that has 2 as its key
WriteLine(format: "Key {0} has value: {1}",
    arg0: key,
    arg1: lookupObject[key]);
WriteLine(format: "Key {0} has value: {1}",
    arg0: harry,
    arg1: lookupObject[harry]);
#endregion

#region Generic types
//Define a generic lookup collection
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;
WriteLine(format: "Key {0} has value: {1}",
arg0: key,
arg1: lookupIntString[key]);
#endregion

#region Add method to Shout delegate
// Assign the method to the Shout delegate.
harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout2;
// Call the Poke method that eventually raises the Shout event.
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();




#endregion

#region Interfaces 
//Comparing Objects while sorting
Person?[] people =
{
    null,
    new() { Name = "Simon" },
    new() { Name = "Jenny" },
    new() { Name = "Adam" },
    new() { Name = null },
    new() { Name = "Richard" }
};

OutputPeopleNames(people, "Initial list of people:");

Array.Sort(people);

OutputPeopleNames(people, "After sorting using Persons IComparable implementation: ");

Array.Sort(people, new PersonComparer());

OutputPeopleNames(people, "After sorting using PersonComparers IComparer implementation: ");
#endregion

#region Inheriting from classes

Employee john = new()
{
    Name = "John",
    Born = new(year: 1990, month: 7, day: 28,
        hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
};

john.WriteToConsole();

#endregion