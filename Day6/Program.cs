using System.Runtime.Intrinsics.X86;
using System.Xml.Schema;

namespace Day6
{
    abstract class Question
    {
        public int id { get; set; }
        public string body { get; set; }
        public double mark { get; set; }
        public Question(int id, string body, double mark)
        {
            this.id = id;
            this.body = body;
            this.mark = mark;
        }
        public abstract void show();
        public static Question take()
        {
            Console.WriteLine("Want\n1)MCQ\n2)TorF"); string s = Console.ReadLine();
            switch (s)
            {
                case "1":
                    return MCQ.take();
                case "2":
                    return TorF.take();
                default:
                    Console.WriteLine("Invalid Option");
                    return null;
            }
        }
    }
    class MCQ : Question
    {
        public string[] chooses { get; set; }
        public MCQ(int id, string body, double mark, string[] chooses) : base(id, body, mark)
        {
            this.chooses = chooses;
        }
        public override void show()
        {
            Console.WriteLine($"{id}-{this.body} ?");
            for (int i = 0; i < chooses.Length; i++)
            {
                Console.WriteLine($"{(char)(i + 97)}){chooses[i]}");
            }
            Console.WriteLine("-------------------------------------");
        }
        public static MCQ take()
        {
            int id; string body; double mark; int size;
            Console.WriteLine($"Enter MCQ");
            Console.Write($"Id:"); id = int.Parse(Console.ReadLine());
            Console.Write($"Body:"); body = Console.ReadLine();
            Console.Write($"Mark:"); mark = double.Parse(Console.ReadLine());
            Console.Write($"Chooses Number:"); size = int.Parse(Console.ReadLine());

            string[] chooses = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"choose {i + 1} :"); chooses[i] = Console.ReadLine();
            }
            return new MCQ(id, body, mark, chooses);
        }
    }
    class TorF : Question
    {
        public TorF(int id, string body, double mark) : base(id, body, mark)
        {

        }
        public override void show()
        {
            Console.WriteLine($"{id}-{this.body} ?");
            Console.WriteLine("a)True");
            Console.WriteLine("b)False");
            Console.WriteLine("-------------------------------------");

        }
        public static TorF take()
        {
            int id; string body; double mark; int size;

            Console.WriteLine($"Enter TorF");
            Console.Write($"Id:"); id = int.Parse(Console.ReadLine());
            Console.Write($"Body:"); body = Console.ReadLine();
            Console.Write($"Mark:"); mark = double.Parse(Console.ReadLine());

            return new TorF(id, body, mark);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region create single object of abstract class
            //Question q=new Question(); XXXXXXXXXX
            //Question mcq = new MCQ(1, "af", 12, new string[3]);
            //Question torf = new TorF(1, "af", 12);

            #endregion

            Console.WriteLine("-----------Welcome to Exam Planner-----------");
            Console.WriteLine("what's number of questions you want?");
            int size = int.Parse(Console.ReadLine());
            Question[] data = new Question[size];
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("*");
                data[i] = Question.take();
                Console.WriteLine(data[i].GetType());
            }
            Console.WriteLine("\n-----------E--x--a--m-----------");
            for (int i = 0; i < data.Length; i++)
            {
                data[i].show();
            }
        }
    }
}