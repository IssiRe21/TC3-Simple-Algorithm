using System;

namespace TC3_Simple_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Escribe un numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[numero];
            
            

            static void Añadir(int[]nums, int numero)
            {
                for (int i = 0; i < numero; i++)
                {
                    nums[i]=i+1;
                }
            }


            static void PrintArray(int[] nums)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                 System.Console.WriteLine(nums[i]);
                }
            }

            Añadir(arr, numero);
            PrintArray(arr);



        }
    }
}
