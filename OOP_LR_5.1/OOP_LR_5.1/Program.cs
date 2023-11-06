using System;

namespace OOP_LR_5._1
{
    abstract class Parent
    {
        public abstract string Info();
        public abstract double Metod(double x);
    }
    class Child1 : Parent
    {
        private double b;
        private double c;
        public Child1(double b, double c)
        {
            this.b = b; this.c = c;
        }
        public override string Info()
        {
            return $"y = {b}x + {c}";
        }
        public override double Metod(double x)
        {
            return b * x + c;
        }
    }
    class Child2 : Parent
    {
        private double a;
        private double b;
        private double c;
        public Child2(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
        }
        public override string Info()
        {
            return $"y = {a}x*x + {b}x + {c}";
        }
        public override double Metod(double x)
        {
            return a * x * x + b * x + c;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Parent p;
            Random rnd = new Random();
            double m = 0;
            for (int i = 0; i < 5; i++)
            {
                double a = rnd.Next(0, 6);
                double b = rnd.Next(0, 6);
                double c = rnd.Next(0, 6);
                double x = rnd.Next(0, 6);

                if (a == 0)
                {
                    p = new Child1(b, c);
                }
                else
                {
                    p = new Child2(a, b, c);
                }
                Console.Write(p.Info());
                m = p.Metod(x);
                Console.WriteLine("\ty({0}) = {1}",x ,m);
            }
            Console.ReadKey();
        }
    }
}
