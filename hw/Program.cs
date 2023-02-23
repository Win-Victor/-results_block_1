void PrintArray(string[] array)
{
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

void FilterArrayStringsLength(string[] array)
{
    string[] tempArray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        {
            tempArray[count] = array[i];
            count++;
        }
    }
    string[] newArray = new string[count];
    for (int i = 0; i < count; i++)
    {
        newArray[i] = tempArray[i];        
    }
    PrintArray(newArray);
}

string[] arrString1 = {"hello", "2", "world", ":-)"};
string[] arrString2 = {"1234", "1567", "-2", "computer scince"};
string[] arrString3 = {"Russia", "Denmark", "Kazan"};

FilterArrayStringsLength(arrString1);
FilterArrayStringsLength(arrString2);
FilterArrayStringsLength(arrString3);

