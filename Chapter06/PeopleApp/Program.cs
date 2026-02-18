using Packt.Shared;

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