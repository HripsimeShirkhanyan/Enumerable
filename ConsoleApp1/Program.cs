using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new C();
            a.Print();
        }
    }

    public class A
    {
        public virtual void Print()
        {
            Console.WriteLine("Class A");
        }
    }

    public class B : A
    {
        public override void Print()
        {
            Console.WriteLine("Class B");
        }
    }
    public class C : B
    {
        public new void Print()
        {
            Console.WriteLine("Class C");
        }
    }
}
