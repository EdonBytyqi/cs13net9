// See https://aka.ms/new-console-template for more information
string[] names;

names = new string[4];
names[0] = "Alice";
names[1] = "Bob";
names[2] = "Charlie";
names[3] = "Diana";

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"Name {i + 1}: {names[i]}");
}

string[] names2 = { "Eve", "Frank", "Grace", "Heidi" };
for (int i = 0; i < names2.Length; i++)
{
    Console.WriteLine($"Name {i + 1}: {names2[i]}");
}

string[,] grid = new string[2, 3]
{
    { "A1", "A2", "A3" },
    { "B1", "B2", "B3" }
};
for (int row = 0; row < grid.GetLength(0); row++)
{
    for (int col = 0; col < grid.GetLength(1); col++)
    {
        Console.WriteLine($"Element at ({row}, {col}): {grid[row, col]}");
    }
}

string[][] jaggedArray = new string[2][];
jaggedArray[0] = new string[] { "X1", "X2" };
jaggedArray[1] = new string[] { "Y1", "Y2   ", "Y3" };   
for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.WriteLine($"Element at ({i}, {j}): {jaggedArray[i][j]}");
    }
}

