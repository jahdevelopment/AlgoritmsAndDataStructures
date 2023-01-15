string initialStr = "Programmatic Python";

string str = "";

string repChars;



for (int i = 0; i < initialStr.Length; i++)
{
    for (int j = i + 1; j < initialStr.Length; j++)
    {
        if (initialStr[i] == initialStr[j])
        {
            repChars = initialStr[j].ToString().ToLower();
            Console.Write(repChars);
        }
    }
}


