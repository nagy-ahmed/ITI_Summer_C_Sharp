using System;
namespace Day4
{
    class Player
    {
        public int num { get; set; }
        public string name { get; set; }
        public int position { get; set; }
        public Player(int num, string name)
        {
            this.num = num;
            this.name = name;
            position = 0;
        }
        public Player(int num, string name, int position)
        {
            this.num = num;
            this.name = name;
            this.position = position;
        }
        public string GetString()
        {
            return $"-Player no {num} his name {name} his position {position}";
        }
        public static Player TakeInput()
        {
            Console.WriteLine("Plz enter player number ,name ,position ");
            int num = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int position = int.Parse(Console.ReadLine());
            return new Player(num, name, position);
        }
    }
    class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public Player[] Players { get; set; }
        public Team()
        {
            id = 1;
        }
        public Team(int id, string name, string desc, Player[] Players)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
            this.Players = Players;
        }
        public string GetString()
        {
            string txt = $"Team {id} Name :{name} Desc: {desc} \n";
            foreach (Player item in Players)
            {
                txt += item.GetString() + "\n";
            }
            return txt;
        }
        public static Team TakeInput()
        {
            Console.WriteLine("Plz enter Team id ,name ,description ");
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string desc = Console.ReadLine();

            Console.WriteLine("please enter number of team players"); int size = int.Parse(Console.ReadLine());
            Player[] arr = new Player[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Player.TakeInput();
            }
            return new Team(id, name, desc, arr);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Player p1 = new Player(1, "ali", 8);
            //Player p2 = new Player(2, "mos", 6);
            //Player p3 = new Player(3, "mah", 1);
            //Player p4 = new Player(4, "ahmed", 10);
            //Player[] arr = new Player[] { p1, p2, p3, p4 };
            //Team t = new Team(10, "al", "blabla", arr);
            //Console.WriteLine(t.GetString());
            #endregion
            Team t = Team.TakeInput();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(t.GetString());
        }
    }
}