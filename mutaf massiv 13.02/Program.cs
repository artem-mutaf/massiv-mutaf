using System;

namespace mutaf_massiv_13._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("n=");
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //for(int i =0;i <array.Length;i++)
            //{
            //    Console.Write($"array [{i}] = ");
            //    array[i] = int.Parse(Console.ReadLine());



            //}
            //int p = array[0];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = array[i] + p;
            //    //array[i]+=array[0];
            //}
            //for(int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"array[{i}]={array[i]}");
            //}
            //Console.ReadKey();  

            //Console.Write("n=");
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"array [{i}] = ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //int count = 0;
            //foreach (int elem in array)
            //{
            //    if (elem % 2 == 0) count++;
            //}
            //Console.WriteLine($"count={count}");
            //Console.ReadKey();
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i<array.Length;i++)
            {
                array[i] = rnd.Next(-50,50);
                Console.WriteLine($"array[{i}]= {array[i]}");

            }
            int max =array [0];
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i]>max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"max= {max}");

        }
    }
}
