using System;

class Dublicate
{
    public static void Main()
    {
        Console.WriteLine("Enter number of Element in an array");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter " + n + " Elements...");
        for (int i = 0; i < n; i++)
        {

            arr[i] =int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Duplicate elements:");
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                    Console.WriteLine(arr[i]+ " ");
            }
        }
    }
}