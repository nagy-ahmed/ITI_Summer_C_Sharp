namespace Day8
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public override string? ToString()
        {
            return $"-{name.ToUpper()} {age} years old";
        }
        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public static Student take()
        {
            Console.WriteLine($"Enter student info");
            Console.Write($"id:"); int id = int.Parse(Console.ReadLine());
            Console.Write($"name:"); string name = Console.ReadLine();
            Console.Write($"age:"); int age = int.Parse(Console.ReadLine());
            return new Student(id, name, age);
        }
    }
    class Subject
    {
        public int id { get; set; }
        public string name { get; set; }
        public int duration { get; set; }
        public override string? ToString()
        {
            return $"{id}-{name} duration:{duration}";
        }
        public Subject(int id, string name, int duration)
        {
            this.id = id;
            this.name = name;
            this.duration = duration;
        }
        public static Subject take()
        {
            Console.WriteLine($"Enter Subject info");
            Console.Write($"id:"); int id = int.Parse(Console.ReadLine());
            Console.Write($"name:"); string name = Console.ReadLine();
            Console.Write($"duration:"); int duration = int.Parse(Console.ReadLine());
            return new Subject(id, name, duration);
        }
    }
    internal class Program
    {
        static Dictionary<Student, List<Subject>> data = new Dictionary<Student, List<Subject>>();
        static void TakeInput()
        {
            Console.WriteLine("Enter student no");
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.Write($"{i + 1})");
                Student s = Student.take();
                List<Subject> subjects = new List<Subject>();
                Console.WriteLine("Enter Subject no"); int no = int.Parse(Console.ReadLine());
                for (int j = 0; j < no; j++)
                {
                    subjects.Add(Subject.take());
                }
                data.Add(s, subjects);
            }
            Console.WriteLine("------------------------------\n");

        }

        static void Main(string[] args)
        {
            #region dummy data
            //Student s1 = new Student(1, "ahmed", 22);
            //Student s2 = new Student(2, "ali", 21);
            //List<Subject> subjects = new List<Subject>()
            //{
            //    new Subject(1,"c#",3),
            //    new Subject(2,"mssql",2),
            //    new Subject(3,"DB",4),
            //    new Subject(4,"linq",1),
            //};
            //data.Add(s1, subjects);
            //data.Add(s2, subjects);
            #endregion

            TakeInput();
            foreach (var i in data)
            {
                Console.WriteLine(i.Key.ToString());
                foreach (var j in i.Value)
                {
                    Console.WriteLine(j.ToString());
                }
                Console.WriteLine("------------------------------\n");
            }
        }
    }
}