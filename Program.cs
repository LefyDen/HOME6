using System;

namespace home6
{
    class Program
    {
        static void Main(string[] args)
        {
            //first method
            int[] arr = { 90, 954, 7, -152, -67 };
            C Console.WriteLine("\n");
            Console.WriteLine("Old array :");
            foreach (int fa in arr)
            {
                Console.Write(fa + " ");
            }
            int n = arr.Length;                
                for (int i = 0; i < n - 1; i++)
                {                   
                    int min = i;
                    for (int j = i + 1; j < n; j++)
                        if (arr[j] < arr[min])
                    {
                            min = j;
                    }                 
                    int temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }
            Console.WriteLine("\n");
            Console.WriteLine("Sorted array :");
            foreach (int fa in arr)
            {
                Console.Write(fa + " ");
            }



            //second method 
            int[] a = { 87, 9, 7, -15, -143 };
            Console.WriteLine("\n");
            Console.WriteLine("Old array :");
            foreach (int fa in a)
            {
                Console.Write(fa + " ");
            }
            int z;           
            for (int p = 0; p <= a.Length - 2; p++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {

                        z = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = z;
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Sorted array :");
            foreach (int fa in a)
            {
                Console.Write(fa + " ");
            }

            //third method

            int[] numbers =  { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("\n");
            Console.WriteLine( "Old array :");
            foreach (int fa in numbers)
            {
                Console.Write(fa + " ");
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        int temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Sorted array :");
            foreach (int fa in numbers)
            {
                Console.Write(fa + " ");
            }
        }
    }
}
