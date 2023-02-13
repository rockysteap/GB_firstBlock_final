    // Написать программу, которая из имеющегося массива строк формирует 
    // массив из строк, длина которых меньше либо равна 3 символа.
internal class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string[] inputArray1 = {"hello", "2", "world", ":-)"};
        string[] inputArray2 = {"1234", "1567", "-2", "computer science"};
        string[] inputArray3 = {"Russia", "Denmark", "Kazan"};
    }

    static string[] GetFilteredArray(string[] inArray, int inLimiter)
    {
        int resultArraySize = 0;
        string[] resultArray = new string[resultArraySize];
        for (int i = 0; i < inArray.Length; i++)
        {
            if (inArray[i].Length <= inLimiter)
            {
                resultArraySize++;
                Array.Resize(ref resultArray, resultArraySize);
                resultArray[resultArraySize - 1] = inArray[i];
            }
        }
        return resultArray;
    }
}