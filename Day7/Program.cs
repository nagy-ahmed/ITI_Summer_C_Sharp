using System.Collections.Concurrent;
using System.Data.Common;

namespace Day7
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public Student(int id = 0, string name = "", int age = 0)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return $"id={id} , name={name} , age={age}";
        }
        #region operator overload
        public static bool operator >(Student a, Student b)
        {
            return a.age > b.age;
        }
        public static bool operator <(Student a, Student b)
        {
            return a.age < b.age;
        }
        public static bool operator ==(Student a, Student b)
        {
            return a.age == b.age;
        }
        public static bool operator !=(Student a, Student b)
        {
            return a.age != b.age;
        }
        #endregion
        #region user-defined casting
        public static implicit operator int(Student s)
        {
            return s.id;
        }
        public static explicit operator string(Student s)
        {
            return s.name;
        }
        #endregion
    }

    struct Complex
    {
        public int real { get; set; }
        public int img { get; set; }
        public Complex(int real = 0, int img = 0)
        {
            this.real = real;
            this.img = img;
        }
        public override string ToString()
        {
            return $"=> {real} + {img}i";
        }
        #region operator overload
        public static Complex operator +(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.real = a.real + b.real;
            c.img = a.img + b.img;
            return c;
        }
        public static Complex operator -(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.real = a.real - b.real;
            c.img = a.img - b.img;
            return c;
        }
        public static bool operator ==(Complex a, Complex b)
        {
            return a.real == b.real && a.img == b.img;
        }
        public static bool operator !=(Complex a, Complex b)
        {
            return a.real != b.real && a.img != b.img;
        }
        // > , <
        public static bool operator >(Complex a, Complex b)
        {
            double x1 = Math.Pow(a.real, 2) + Math.Pow(a.img, 2);
            double x2 = Math.Pow(b.real, 2) + Math.Pow(b.img, 2);
            return x1 > x2;
        }
        public static bool operator <(Complex a, Complex b)
        {
            double x1 = Math.Pow(a.real, 2) + Math.Pow(a.img, 2);
            double x2 = Math.Pow(b.real, 2) + Math.Pow(b.img, 2);
            return x1 < x2;
        }
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------complex examples
            Complex c1 = new Complex(10, 20);
            Complex c2 = new Complex(1, 2);
            Console.WriteLine($"sum {c1 + c2}");
            Console.WriteLine($"sub {c1 - c2}");
            Console.WriteLine($"== {c1 == c2}");
            Console.WriteLine($"c1>c2 {c1 > c2}");
            Console.WriteLine($"c1<c2 {c1 < c2}");

            //------------------------------------------student operator overload examples
            Console.WriteLine("------------------------------------------------");

            Student s1 = new Student(1, "mohamed", 21);
            Student s2 = new Student(2, "ahmed", 22);

            if (s1 > s2)
            {
                Console.WriteLine("s1 is greater");
            }
            else
            {
                Console.WriteLine("s2 is greater");
            }

            //------------------------------------------student user-defined casting examples
            Console.WriteLine("------------------------------------------------");

            Student s = new Student(444, "test");
            int x = s; Console.WriteLine(x);
            string y = (string)s; Console.WriteLine(y);

        }
    }
}