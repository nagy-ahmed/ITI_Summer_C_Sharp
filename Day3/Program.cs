using System;

namespace Day3
{
    struct Complex
    {
        public int real { get; set; }
        int img;
        public int Img
        {
            get { return img; }
            set
            {
                if (value > 0)
                {
                    img = value;
                }
                else
                {
                    img = 0;
                }
            }
        }
        public void print()
        {
            Console.WriteLine($"{real}+{Img}i");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter arr size"); int size = int.Parse(Console.ReadLine());
            Complex[] arr = new Complex[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"enter real  : "); arr[i].real = int.Parse(Console.ReadLine());
                Console.WriteLine($"enter img  : "); arr[i].Img = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Complex Numbers");
            foreach (Complex item in arr)
            {
                item.print();
            }
        }
    }
}