using System;

namespace Day2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter no of Tracks : "); bool isValidTra = int.TryParse(Console.ReadLine(), out int noOfTracks);
            Console.Write("Enter no of Students : "); bool isValidStu = int.TryParse(Console.ReadLine(), out int noOfStudents);

            if (isValidTra && isValidStu)
            {
                int[,] data = new int[noOfTracks, noOfStudents];
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    Console.WriteLine($"Enter Ages of Track {i + 1} Students:");
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        Console.Write($"Student {j + 1} age = "); int.TryParse(Console.ReadLine(), out data[i, j]);
                    }
                }
                int sum = 0;
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    Console.WriteLine($"\n\tAges of Track {i + 1} Students:");
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        Console.WriteLine($"Student {j + 1} age = {data[i, j]}");
                        sum += data[i, j];
                    }
                    Console.WriteLine($"Avg of students ages = {Math.Round(sum * 1.00 / data.GetLength(1), 2)}");
                    sum = 0;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}