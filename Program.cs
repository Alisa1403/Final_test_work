void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] inputArray = { "hsju", "eee", "ngv668lh", "776ff@@", "1829j", "$$", "@$$$$$$", "qwf", "uhgfdfsf", "b7tbb2", "^" };
string[] outputArray = new string[inputArray.Length];
int n =0;
int size = 4;

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length < size)
    {   
        outputArray[n] = inputArray[i];
        n++;
    }
}

Print(outputArray);