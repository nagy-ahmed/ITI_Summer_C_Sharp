namespace Day5
{

    class A
    {
        public virtual void Foo()
        {
            Console.WriteLine("test");
        }
    }
    class B : A
    {
        public new virtual void Foo()
        {
            Console.WriteLine("HI");
        }
    }
    class C : B
    {
        public override void Foo()
        {
            Console.WriteLine("C");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.Foo();
        }
    }
}