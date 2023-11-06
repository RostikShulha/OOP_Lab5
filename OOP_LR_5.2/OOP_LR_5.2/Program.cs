using System;
using System.Text;

namespace OOP_LR_5._2
{
    interface IParent
    {
        string Info();
        double Metod();
    }

    class Child1 : IParent//Морський транспорт
    {
        public double pole1 { get; set; }//pole1 - Швидкість
        public double pole2 { get; set; }//pole2 - Собівартість
        public double pole3 { get; set; }//pole3 - Вартість
        public Child1(double pole1, double pole2)
        {
            this.pole1 = pole1;
            this.pole2 = pole2;
        }
        public string Info()
        {
            return $"Швидкість: {pole1}  Собівартість: {pole2}";
        }
        public double Metod()
        {
            pole3 = pole2 / pole1;
            return pole3;
        }
    }

    class Child2 : IParent//Наземний транспорт
    {
        public double pole1 { get; set; }
        public double pole2 { get; set; }
        public double pole3 { get; set; }
        public double pole4 { get; set; }

        public Child2(double pole1, double pole2, double pole4)
        {
            this.pole1 = pole1;
            this.pole2 = pole2;
            this.pole4 = pole4;
        }
        public string Info()
        {
            return $"Швидкість: {pole1}  Собівартість: {pole2}  Дорожній збір: {pole4}";
        }
        public double Metod()
        {
            pole3 = pole2 / pole1 + pole4;
            return pole3;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            IParent p = null;
            Random rnd = new Random();
            double pole4 = 0;//pole4 - Дорожній збір
            for(int i = 0; i < 5; i++)
            {
                double pole1 = rnd.Next(40, 101);
                double pole2 = rnd.Next(10, 51);
                int typ = rnd.Next(0, 2);//0 - Морський, 1 - Наземний

                if (typ == 0)
                {
                    Console.Write("Морський. ");
                    p = new Child1(pole1, pole2);
                }
                else
                {
                    Console.Write("Наземний. ");
                    pole4 = rnd.Next(10, 51);
                    p = new Child2(pole1, pole2, pole4);
                }
                Console.Write(p.Info());
                Console.Write("  Вартість: {0:f2}", p.Metod());
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
