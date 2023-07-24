using System.Reflection.Metadata;

namespace Day4
{
    #region Struct
    //struct Complexnum
    //{

    //    public int real { get; set; }
    //    int img;
    //    public int Img
    //    {
    //        set
    //        {
    //            if (value >= 0)
    //                img = value;
    //            else
    //                img = 0;
    //        }
    //        get { return img; }
    //    }
    //public Complexnum()
    //{
    //    real = 1;
    //    img = 1;
    //}

    //public Complexnum(int real, int img)
    //{
    //    this.real = real;
    //    this.img = img;
    //}
    //public Complexnum(int real) : this(real, 1) //constractor chaining
    //{
    //   //  Complexnum(real, 1);

    //    //this.real = real;
    //    //img = 1;
    //}
    //    public string print()
    //    {
    //       return $"{real}+{Img}i";
    //    }
    //}

    //class Complexnum
    //{

    //    public int real { get; set; }
    //    int img;
    //    public int Img
    //    {
    //        set
    //        {
    //            if (value >= 0)
    //                img = value;
    //            else
    //                img = 0;
    //        }
    //        get { return img; }
    //    }
    //    public Complexnum()
    //    {
    //        real = 1;
    //        img = 1;
    //    }

    //    public Complexnum(int real, int img)
    //    {
    //        this.real = real;
    //        this.img = img;
    //    }
    //    public Complexnum(int real) : this(real, 1) //constractor chaining
    //    {
    //        // Complexnum(real, 1);

    //        //this.real = real;
    //        //img = 1;
    //    }

    //    ~Complexnum()
    //    {
    //        Console.WriteLine("Destractor");
    //    }


    //    public string print()
    //    {
    //        return $"{real}+{Img}i";
    //    }
    //}
    #endregion


    class Subject
    {
        public int id { get; set; }
        public string name { get; set; }
        public int duration { get; set; }


        public Subject()
        {
            id = 1;
            duration = 12;
        }

        public Subject(int id, string name)
        {
            this.id = id;
            this.name = name;
            duration = 12;

        }
        public Subject(int id, string name, int duration)
        {
            this.id = id;
            this.name = name;
            this.duration = duration;
        }


        public string print()
        {
            return $"{id} - {name} \t \t {duration} Hours";
        }

    }
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public Subject[] sub { get; set; }
        public Student()
        {
            id = 1;
        }
        public Student(int id, string name, int age, Subject[] sub)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.sub = sub;
        }

        public string print()
        {
            string txt = $"{id} - {name} \t \t {age} years old \n";
            for (int i = 0; i < sub.Length; i++)
            {
                txt += sub[i].print() + "\n";
            }
            return txt;
        }




    }
    internal class demo
    {
        static void test(string[] args)
        {
            #region constractor

            //  Complexnum c = new Complexnum(5,7); //constractor >> special function 

            // Complexnum c1 = new Complexnum();
            // Complexnum c2 = new Complexnum(8);
            //Console.WriteLine(c1.print());
            //Console.WriteLine(c.print());
            // Console.WriteLine(c2.print());
            #endregion

            #region this
            // Complexnum c2 = new Complexnum(8);
            // Console.WriteLine(c2.print());

            #endregion


            #region class
            //ref datatype
            // store ref stack >> data(object) heap
            // new >>storage  >> return ref  >> call constractor


            //Complexnum c = new Complexnum(5); // create object
            #endregion

            #region array of class
            //Console.WriteLine("Enter num of subjects");
            //int numOfSubject = int.Parse(Console.ReadLine());
            //Subject[] arr = new Subject[numOfSubject];
            //for (int i = 0; i < numOfSubject; i++)
            //{
            //    arr[i] = new Subject();
            //    Console.WriteLine("Enter id");
            //    arr[i].id= int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter name");
            //    arr[i].name = Console.ReadLine();
            //    Console.WriteLine("Enter duration");
            //    arr[i].duration = int.Parse(Console.ReadLine());

            //}

            //for (int i = 0; i < numOfSubject; i++)
            //{
            //    Console.WriteLine(arr[i].print());
            //}



            #endregion

            #region class relation  Is-A  Has-A
            //Subject sub = new Subject(1, "oop", 20);

            //Student s = new Student(1, "ali", 22, sub);
            //Console.WriteLine(s.print());


            Subject[] arr = new Subject[3]
            {
                new Subject(1,"oop",20),
                new Subject(2,"C3" ,30),
                new Subject(3,"js",50)
            };
            Student s = new Student(1, "ali", 22, arr);

            Console.WriteLine(s.print());
            #endregion

        }
    }
}