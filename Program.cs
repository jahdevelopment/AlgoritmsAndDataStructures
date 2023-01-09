Console.WriteLine("Please give me the number of words you want to write");
int arrayNumb = Int32.Parse(Console.ReadLine());

string[] arrayOfWords = new string[arrayNumb];

for(int i = 0; i< arrayOfWords.Length; i++)
{
    Console.WriteLine($"Please write the word number {i+1}");
    arrayOfWords[i] = Console.ReadLine();
}

Console.WriteLine("Please give me a letter to count in the list of words:");
char wordToCount = char.Parse(Console.ReadLine());
Console.WriteLine(wordToCount);
