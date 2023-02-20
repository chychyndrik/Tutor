using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] arr = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int max = 0, pre_max = 0;
        max = arr.Max();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > pre_max && max == arr[i])
            {
                pre_max = arr[i];
            }
        }
        Console.WriteLine("pre_max");
        Console.WriteLine(pre_max);
        Console.ReadLine();
    }
}