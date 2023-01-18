Console.WriteLine("---------------- FIRST PROBLEM ----------------");

// ist<int> MaxNumbersInLists(List<List<int>>) accepts as a parameter
// a List of Lists of Integers. It returns a new list with each element
// representing the maximum number found in the corresponding original list.

List<List<int>> MaxNumberInLists = new List<List<int>>();

Console.WriteLine("\nHow many lists do you want to store?");

int bigList = Int32.Parse(Console.ReadLine());

for (int i = 0; i < bigList; i++)
{
    List<int> innerList= new List<int>();

    Console.WriteLine($"\nPlease enter the number of elements of the list {i+1}");
    
    int nestedList = Int32.Parse(Console.ReadLine());

    for (int j = 0;j < nestedList; j++)
    {
        Console.WriteLine($"Please add the number {j+1} of the list {i+1}");

        innerList.Add(Int32.Parse(Console.ReadLine()));
    }
    MaxNumberInLists.Add(innerList);
}

for (int i = 0; i < MaxNumberInLists.Count; i++)
{
    int max = 0;
    
    for (int j = 0; j < MaxNumberInLists[i].Count; j++)
    {
        if (MaxNumberInLists[i][j] > max)
        {
            max = MaxNumberInLists[i][j];
        }
    }
Console.Write($"\nList {i + 1} has a maximum of {max}. ");
}


Console.WriteLine("\n\n---------------- SECOND PROBLEM ----------------\n");

// String HighestGrade(List<List<int>>) accepts a list of number grades among students
// in different courses (where each list represents a single course), between 0 and 100.
// It returns the highest grade among all students in all courses




