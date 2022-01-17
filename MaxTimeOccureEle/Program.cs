using System;

class MaxTimeOccureElements
{
    int count = 0;
    int max = 0;
    public static void Main()
     
    {
        MaxTimeOccureElements mt = new MaxTimeOccureElements();
        Console.WriteLine("Enter number of Element in an array");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter " + n + " Elements...");
        for (int i = 0; i < n; i++)
        {

            arr[i] = int.Parse(Console.ReadLine());
        }
        
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    mt.count++;
                    mt.max = arr[i];
                }
                   
            }
        }
        Console.WriteLine("Maximum time occure element:"+mt.max + " ");
    }
}