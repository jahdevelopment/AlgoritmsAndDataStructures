// We have a list of integers where elements appear either once or twice.
// Find the elements that appeared twice in O(n) time.
// example: { 1, 2, 3, 4, 7, 9, 2, 4}
// returns { 2, 4}

int[] input = { 1, 2, 3, 4, 7, 9, 2, 4 };

string pairs = "";

for(int i = 0; i < input.Length; i++)
{
    for(int j = i + 1; j < input.Length; j++)
    {
        if (input[i] == input[j])
        {
            pairs += input[i];
        }
    }
}

string findingPairs = string.Join(", ",pairs );

Console.WriteLine(findingPairs);
