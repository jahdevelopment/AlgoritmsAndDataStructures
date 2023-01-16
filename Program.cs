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


Console.WriteLine("\n\n==================== FOURTH PROBLEM ====================\n");

// A program that finds the longest unbroken word in a string and prints it

string paragraph = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";

Console.WriteLine(paragraph);

string[] findingLongest = paragraph.Split(' ', ',', '.');

int lengthOfWord = 0;

string selectedWord = "";

for (int i = 0;i < findingLongest.Length; i++)
{
    if (findingLongest[i].Length >= lengthOfWord)
    {
        lengthOfWord = findingLongest[i].Length;
        selectedWord = string.Concat(findingLongest[i]);
    }
}
Console.WriteLine($"\nThe longest word of the paragraph is: {selectedWord} " +
        $"with {lengthOfWord} characters.");

Console.WriteLine("\n\n==================== END OF LAB 2 ====================\n");