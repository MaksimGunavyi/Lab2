using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee("Maks", "Huniavyi", "Junior", 5);
            person1.Print();
        }

        class Employee
        {
            private string name { get; set; }
            private string surname { get; set; }
            private string spot { get; set; }
            private int experience { get; set; }
            private double finish_wage { get; set; }

            public Employee(string name, string surname, string spot, int experience)
            {
                this.name = name;
                this.surname = surname;
                this.spot = spot;
                this.experience = experience;
            }

            public void Print()
            {
                double defoult_wage = 10000;
                double tax = 0.9;

                if ("Junior" == spot)
                {
                    finish_wage = defoult_wage * 1 * experience * tax;
                }
                else if ("Middle" == spot)
                {
                    finish_wage = defoult_wage * 2 * experience * tax;
                }
                else if ("Senior" == spot)
                {
                    finish_wage = defoult_wage * 3 * experience * tax;
                }

                Console.WriteLine($"Iм'я: {name} \nПрiзвище: {surname} \nПосада: {spot} \nЗарплатня: {finish_wage} \nПодатковий збiр 10%");
            }
        }
    }
}