// List of integers where elements appear either once or twice.
// Find the elements that appeared twice.

Console.WriteLine("******************** FIRST PROBLEM ********************\n");

int[] input = { 1, 2, 3, 4, 7, 9, 2, 4 };

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

Console.WriteLine(findingPairs);

Console.WriteLine("******************** SECOND PROBLEM ********************\n");

// We have two sorted int arrays which could be with different sizes.
// We need to merge them in a third array while keeping this result array sorted.
//returns
//{ 1, 2, 2, 3, 4, 5, 5, 7, 9, 13}

int[] firstArray = new int[5] { 1, 2, 3, 4, 5 };
int[] secondArray = new int[5] {2, 5, 7, 9, 13};
int[] thirdArray = new int[firstArray.Length + secondArray.Length];

thirdArray = firstArray.Concat(secondArray).ToArray();
Array.Sort(thirdArray);

string result = string.Join(", ", thirdArray);
Console.WriteLine(result);
