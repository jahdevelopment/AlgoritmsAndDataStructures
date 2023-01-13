// prompt a user for an integer,which is the length of the array word list:

Console.WriteLine("Please give me the number of words you want to write");
int arrayNumb = Int32.Parse(Console.ReadLine());

// Secure that the number has to be positive:

while (arrayNumb <= 0)
{
    Console.WriteLine("Give a number greater than 0 (cero):");
    arrayNumb = Int32.Parse(Console.ReadLine());
} 

//Creation of the string or arrays to store the words:

string[] arrayOfWords = new string[arrayNumb];

// Prompt the user for n words, one to fill each index in the array:

for(int i = 0; i < arrayNumb; i++)
{
    Console.WriteLine($"Please write the word number {i+1}");
    arrayOfWords[i] = Console.ReadLine();
}

// Prompt the user to enter a single character to count:

Console.WriteLine("Please give me a letter to count in the list of words:");
char charToCount = Console.ReadKey().KeyChar;

// Creating a new array of characters to keep all the characters given in the above string of arrays:

string newArray = "";
int count = 0;

for (int i = 0; i < arrayOfWords.Length; i++)
{
    newArray = string.Join("", arrayOfWords);
}

// Counting the occurrencies of that character within the newArray string:

int repetitions = 0;

foreach (char c in newArray)
{
    if (c == charToCount)
    {
        repetitions++;
    }
}

// Print the number of occurrences repeated:

Console.WriteLine($"\nThe leter {charToCount} is repeated {repetitions} times in the list of words");

// Calculate and print the percentage of ocurrences of that character comparing with the
// total of the characters of the newArray string:

int totalCharacters = newArray.Length;

double percentage = ((double)repetitions / (double)totalCharacters * 100);

Console.WriteLine($"This is the {percentage}% of the total of characters");