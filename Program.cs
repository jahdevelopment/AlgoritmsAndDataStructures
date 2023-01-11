Console.WriteLine("Please give me the number of words you want to write");
int arrayNumb = Int32.Parse(Console.ReadLine());

string[] arrayOfWords = new string[arrayNumb];

for(int i = 0; i < arrayNumb; i++)
{
    Console.WriteLine($"Please write the word number {i+1}");
    arrayOfWords[i] = Console.ReadLine();
}

Console.WriteLine("Please give me a letter to count in the list of words:");
char charToCount = Console.ReadKey().KeyChar;

string newArray = "";
int count = 0;

for (int i = 0; i < arrayOfWords.Length; i++)
{
    newArray = string.Join("", arrayOfWords);
}

int repetitions = 0;

foreach (char c in newArray)
{
    if (c == charToCount)
    {
        repetitions++;
    }
}
Console.WriteLine($"\nThe leter {charToCount} is repeated {repetitions} times in the list of words");
