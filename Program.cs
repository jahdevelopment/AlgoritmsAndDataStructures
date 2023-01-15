using System.Text;

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


