using System.Numerics;

Console.WriteLine("---------------- FIRST PROBLEM ----------------");

/*List<int> MaxNumbersInLists(List<List<int>>) accepts as a parameter
a List of Lists of Integers. It returns a new list with each element
 representing the maximum number found in the corresponding original list.*/

List<List<int>> MaxNumberInLists = new List<List<int>>();

Console.WriteLine("\nHow many lists do you want to store?");

int bigList = Int32.Parse(Console.ReadLine());

for (int i = 0; i < bigList; i++)
{
    List<int> innerList = new List<int>();

    Console.WriteLine($"\nPlease enter the number of elements of the list {i + 1}");

    int nestedList = Int32.Parse(Console.ReadLine());

    for (int j = 0; j < nestedList; j++)
    {
        Console.WriteLine($"Please add the number {j + 1} of the list {i + 1}");

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

/*String HighestGrade(List<List<int>>) accepts a list of number grades among students
 in different courses (where each list represents a single course), between 0 and 100.
 It returns the highest grade among all students in all courses*/

List<List<int>> HighestGrade = new List<List<int>>();

Console.WriteLine("\nPlease enter the number total of courses of the school:");
int totalCourses = Int32.Parse(Console.ReadLine());

for (int i = 0; i < totalCourses; i++)
{
    List<int> course = new List<int>();

    Console.WriteLine($"\nPlease enter the number of students of the course {i + 1}");

    int studentsNumber = Int32.Parse(Console.ReadLine());

    for (int j = 0; j < studentsNumber; j++)
    {
        Console.WriteLine($"Please add the grade of the student {j + 1}");

        course.Add(Int32.Parse(Console.ReadLine()));
    }
    HighestGrade.Add(course);
}

int bestGrade = 0;

int bestClass = 0;

for (int i = 0; i < HighestGrade.Count; i++)
{
    for (int j = 0; j < HighestGrade[i].Count; j++)
    {
        if (HighestGrade[i][j] > bestGrade)
        {
            bestGrade = HighestGrade[i][j];

            bestClass = i+1;
            Console.WriteLine(bestClass);
        }
    }
}
Console.WriteLine($"\nThe highest grade is {bestGrade}, it was found in the course {bestClass}.\n");


Console.WriteLine("\n---------------- THIRD PROBLEM ----------------\n");

// List<int> OrderByLooping (List<int>) orders a list of integers, from least to greatest.

List<int> unorderedList = new List<int> { 6, -2, 5, 3 };

List<int> orderByLooping = new List<int>();

int num1 = unorderedList[0];
int num2 = unorderedList[1];
int num3 = unorderedList[2];
int num4 = unorderedList[3];

unorderedList.ToArray();

string Unordered = string.Join(", ", unorderedList);

Console.WriteLine($"Unordered list:\n{Unordered}");

int aux = 0;

if (num1 < num2 && num1 < num3 && num1 < num4)
{
    num1 = num1;
} 
else if (num2 < num1 && num2 < num3 && num2 < num4)
{
    aux = num2;
    num2 = num1;
    num1 = aux;

}
else if (num3 < num1 && num3 < num2 && num3 < num4)
{
    aux = num3;
    num3 = num1;
    num1 = aux;
}
else if (num4 < num1 && num4 < num2 && num4 < num3)
{
    aux = num4;
    num4 = num1;
    num1 = aux;
}

if (num2 < num3 && num2 < num4)
{
    num2 = num2;
}
else if (num3 < num2 && num3 < num4)
{
    aux = num3;
    num3 = num2;
    num2 = aux;
}
else if (num4 < num2 && num4 < num3)
{
    aux = num4;
    num4 = num2;
    num2 = aux;
}

if (num3 > num4)
{
    aux = num4;
    num4 = num3;
    num3 = aux;
}

orderByLooping.Add(num1);
orderByLooping.Add(num2);
orderByLooping.Add(num3);
orderByLooping.Add(num4);

orderByLooping.ToArray();

string ordered = string.Join(", ", orderByLooping);

Console.WriteLine($"\nOrdered List;\n{ordered}");




