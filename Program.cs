string[] array = { "hello", "2", "world", ":-)" };

string[] StringArray3Symol(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] resultarray = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultarray[count] = array[i];
            count++;
        }
    }
    return resultarray;
}

void ShowStringArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[" + array[i] + "]");
    }
}

ShowStringArray(StringArray3Symol(array));