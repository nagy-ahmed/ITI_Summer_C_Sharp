using System;

namespace Day1
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Plz enter \n your name : ");
			String name=Console.ReadLine();
            Console.WriteLine(" year of birth : ");
			int age = 2023 - int.Parse(Console.ReadLine());

            Console.WriteLine($" name : {name}\n age : {age}");
        }
    }
}