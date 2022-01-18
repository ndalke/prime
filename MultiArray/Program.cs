using System;
public class MultiArrayExample
{
    public static void Main(string[] args)
    {
        int[,] arr = new int[3, 3];//declaration of 2D array  
        int[,] arr2 = new int[3, 3];
        arr[0, 1] = 10;//initialization  
        arr[1, 2] = 20;
        arr[2, 0] = 30;
        arr[0, 0] = 10;
        arr[1, 1] = 40;
        arr[1, 0] = 80;
        arr[0, 2] = 50;
        arr[2, 1] = 70;
        arr[2, 2] = 10;
        arr2[0, 1] = 10;//initialization  
        arr2[1, 2] = 20;
        arr2[2, 0] = 30;
        arr2[0, 0] = 10;
        arr2[1, 1] = 40;
        arr2[1, 0] = 80;
        arr2[0, 2] = 50;
        arr2[2, 1] = 70;
        arr2[2, 2] = 10;


        Console.WriteLine("First Matrix");
        //traversal  
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(arr[i, j] + " ");
                //Console.WriteLine(arr2[i, j] + " ");
            }
            Console.WriteLine();//new line at each row  
        }

        Console.WriteLine("Second Matrix");
        //traversal  
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
              //  Console.Write(arr[i, j] + " ");
                Console.Write(arr2[i, j] + " ");
            }
            Console.WriteLine();//new line at each row  
        }
        Console.WriteLine("Addition");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                //  Console.Write(arr[i, j] + " ");
                Console.Write((arr2[i, j]+arr2[i,j]) + " ");
            }
            Console.WriteLine();//new line at each row  
        }
    }
}
