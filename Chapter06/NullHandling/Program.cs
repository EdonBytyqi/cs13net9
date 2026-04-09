using Packt.Shared;


int thisCannotBeNull = 4;
//thisCannotBeNull = null // CS0037 compiler error
WriteLine(thisCannotBeNull);

int? thisCouldBeNull = null;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

//The actual type of int? is Nullable<int>
Nullable<int> thisCouldAlsoBeNull = null;
thisCouldAlsoBeNull = 9;
WriteLine(thisCouldAlsoBeNull);

Address address = new(city: "London")
{
    Building = null,
    Street = null!,
    Region = "UK"
};

WriteLine(address.Building?.Length);
if (address.Street is not null)
{
    WriteLine(address.Street.Length);
}


