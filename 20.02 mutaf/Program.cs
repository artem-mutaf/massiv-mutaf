namespace _20._02_mutaf
{
    internal class Program
    {
        static void Main(string[] args)
        {   //задача 1
            //Console.Write("n=");
            //byte n = byte.Parse(Console.ReadLine());
            //int[] array = new int[5];
            //for(int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"array[{i}]");
            //    array[i]=int.Parse(Console.ReadLine()); 
            //}
            //for(int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"array[{i}]={array[i]}");

            //}
            //Console.ReadKey();
            //задача 2
            //Console.Write("n=");
            //byte n = byte.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //Random rnd = new Random();
            //for(int i = 0; i < n; i++)
            //{
            //    array [i] = rnd.Next(-30, 30);
            //}
            //foreach(int elem in array)
            //{
            //    Console.Write($"{elem}\t");
            //}
            //Console.ReadKey();
            //задача 3
            Console.Write("n=");
            byte n = byte.Parse(Console.ReadLine());
            int[] array = new int[n];
            int max = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if (array[i]>max)
                {
                    max= array[i];
                }
            }
            Console.WriteLine($"{max}");
        }
    }
}