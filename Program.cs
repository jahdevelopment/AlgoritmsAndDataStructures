using System.Text;

Console.WriteLine("==================== FIRST PROBLEM ====================\n");

// A program that produces an array of all of the characters that appear more than once in a string:

string initialStr = "Programmatic Python";

StringBuilder mySB = new StringBuilder();

for (int i = 0; i < initialStr.Length; i++)
{
    for (int j = i + 1; j < initialStr.Length; j++)
    {
        if (initialStr[i].Equals(initialStr[j]))
        {
            mySB.Append(initialStr[i]);
        }
    }
}

Console.WriteLine(mySB.ToString().ToLower());


Console.WriteLine("\n==================== SECOND PROBLEM ====================\n");

// A program returns an array of strings that are unique words found in the argument:

string phrase = "to be or not to be";

string[] wordsList = phrase.Split(' ');

string[] newList = new string[wordsList.Length];

int count = 0;

foreach (string word in wordsList)
{
    if (!newList.Contains(word))
    {
        newList[count] = word;
        count++;
        Console.WriteLine(word);
    }
}


Console.WriteLine("\n==================== THIRD PROBLEM ====================\n");

//A program that reverses a provided string:

string inOrderStr = "juan alberto hernandez acosta";

string inReverseStr = "";

for (int i = inOrderStr.Length - 1; i >= 0; i--)
{
    inReverseStr = string.Concat(inOrderStr[i]);
    Console.Write(inOrderStr[i]);
}