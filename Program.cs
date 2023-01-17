using Microsoft.VisualBasic;
using System;
using System.Text;

Console.WriteLine("******************** FIRST PROBLEM ********************\n");

// List of integers where elements appear either once or twice.
// Find the elements that appeared twice.

int[] input = { 1, 2, 3, 4, 7, 9, 2, 4 };

Console.WriteLine("Initial list:");

string numberInput = string.Join(", ", input);

Console.WriteLine(numberInput);

List<int> pairs = new List<int>();

for(int i = 0; i < input.Length; i++)
{
    for(int j = i + 1; j < input.Length; j++)
    {
        if (input[i] == input[j])
        {
            pairs.Add(input[i]);
        }
    }
}

string findingPairs = string.Join(", ",pairs );

Console.WriteLine("Elements that appear twice:");

Console.WriteLine(findingPairs);

Console.WriteLine("\n******************** SECOND PROBLEM ********************\n");

// Merging in a new int array two sorted int arrays
// which could be with different sizes.

int[] firstArray = new int[5] { 1, 2, 3, 4, 5 };

string first = string.Join(", ", firstArray);

Console.WriteLine($"First array:\n{first}");

int[] secondArray = new int[5] {2, 5, 7, 9, 13};

string second = string.Join(", ", secondArray);

Console.WriteLine($"Second array:\n{second}");

int[] thirdArray = new int[firstArray.Length + secondArray.Length];

thirdArray = firstArray.Concat(secondArray).ToArray();

Array.Sort(thirdArray);

string third = string.Join(", ", thirdArray);

Console.WriteLine($"Third array result:\n{third}");


Console.WriteLine("\n******************** THIRD PROBLEM ********************\n");

Console.WriteLine("Please enter a positive number composed of two or more digits: ");
int inputNumb = Int32.Parse(Console.ReadLine());

bool inputRight = true;

while(inputRight)
{
    if (inputNumb > 0)
    {
        string numbToStr = inputNumb.ToString();

        StringBuilder sb = new StringBuilder();

        for (int i = numbToStr.Length - 1; i >= 0; i--)
        {
            sb.Append(numbToStr[i]);
        }

        string reverse = sb.ToString();
        
        Console.WriteLine($"Reverse number model 1 (including Zeros): {reverse}");
        
        int outputNumb = Int32.Parse(reverse);

        Console.WriteLine($"Reverse number model 2: {outputNumb}");

        inputRight = false;
    }
    else
    {
        Console.WriteLine("Please enter a positive number");
        
        inputNumb = Int32.Parse(Console.ReadLine());
        
        inputRight = true;
    }
}





