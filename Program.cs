using System;

namespace ParamsDemo
{
    class Params
    {
        internal float CalculateAvg(params float[] list)
        {
            int len = list.Length;
            float total, avg;
            total = avg = 0;
            foreach (float i in list)
            {
                Console.WriteLine(i);
                total += i;
            }
            avg = total / len;
            Console.WriteLine("Addition: " + total);
            Console.WriteLine("Total number of elements: " + len);
            return avg;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of elements:");
            Console.WriteLine("Arithmetic Mean: " + new Params().CalculateAvg(1, 2, 3, 4, 5, 6));
            Console.ReadKey();
        }
    }
}
