using System;
public class MultiArrayExample
{
    public static void Main(string[] args)
    {
        //declaration of 2D array  
        int[,] arr3 = new int[3,3];
        int[,] arr4 = new int[3, 3];

       //store elements in first matrix
        Console.WriteLine("Enter elements of first Matrix");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int data = int.Parse(Console.ReadLine());
                arr3[i, j] = data;
            }
        }

        //store elements in secound matrix
        Console.WriteLine("Enter elements of Second Matrix");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int data = int.Parse(Console.ReadLine());
                arr4[i, j] = data;
            }
        }

        //display first matrix
        Console.WriteLine("First Matrix");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(arr3[i, j] + " ");
            }
            Console.WriteLine();
        }


        //display second matrix
        Console.WriteLine("Second Matrix");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                
                Console.Write(arr4[i, j] + " ");
            }
            Console.WriteLine();
        }

        //addition of two matrix
        Console.WriteLine("Addition");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
              
                Console.Write((arr3[i, j] + arr4[i, j]) + " ");
            }
            Console.WriteLine();
        }
    }
}
