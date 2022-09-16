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
            User user = new User("maksimgunavyj9@gmail.com", "Maks", "Huniavyi", 18);
            user.Print();
        }
    }

    class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private string data = "14.09.2022";

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.data = data;
        }
        public void Print()
        {
            Console.WriteLine($"Логин: {login} \nИмя: {name} \nФамилия: {surname} \nВозраст: {age} \nДата заполнения анкеты: {data}");
        }
    }
}