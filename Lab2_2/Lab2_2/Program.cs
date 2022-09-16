using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Converter converter = new Converter(39.8, 40, 0.61);
            Converter1 converter1 = new Converter1(0.027, 0.026, 1.64);


            Console.WriteLine("Выберите операцию \n1.С гривны в валюту \n2.С валюты в гривны");
            int vol2 = Convert.ToInt32(Console.ReadLine());
            switch (vol2)
            {
                case 1:
                    converter.Print();
                    break;
                case 2:
                    converter1.Print1();
                    break;
            }
            Console.ReadKey();
        }
    }

    class Converter1
    {
        private double uah { get; set; }
        private double uah1 { get; set; }
        private double uah2 { get; set; }
        public Converter1(double uah, double uah1, double uah2)
        {
            this.uah = uah;
            this.uah1 = uah1;
            this.uah2 = uah2;
        }
        public void Print1()
        {
            Console.WriteLine("Выберите валюту: \n1.Доллары на гривны \n2.Евро на гривны \n3.Рубли на гривны");
            int vol1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вашу сумму: ");
            double money = Convert.ToInt32(Console.ReadLine());

            switch (vol1)
            {
                case 1:
                    double resu = money / uah;
                    Console.WriteLine("Ваша сумма в гривнах: " + resu);
                    break;

                case 2:
                    double rese1 = money / uah1;
                    Console.WriteLine("Ваша сумма в гривнах: " + rese1);
                    break;
                case 3:
                    double resr1 = money / uah2;
                    Console.WriteLine("Ваша сумма в гривнах: " + resr1);
                    break;
            }
        }
    }

    class Converter
    {
        private double usd { get; set; }
        private double eur { get; set; }
        private double rub { get; set; }


        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;

        }
        public void Print()
        {
            Console.WriteLine("Выберите валюту: \n1.Доллар \n2.Евро \n3.Рубль");
            int vol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вашу сумму в гривнах: ");
            double uan = Convert.ToInt32(Console.ReadLine());

            switch (vol)
            {
                case 1:
                    double resd = uan / usd;
                    Console.WriteLine("Ваша сумма в долларах состовляет: " + resd);
                    break;

                case 2:
                    double rese = uan / eur;
                    Console.WriteLine("Ваша сумма в евро состовляет: " + rese);
                    break;
                case 3:
                    double resr = uan / rub;
                    Console.WriteLine("Ваша сумма в евро состовляет: " + resr);
                    break;
            }
        }
    }
}