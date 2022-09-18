using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{

    //    Создать абстрактный базовый класс Worker(работника)
    //с методом Print(). Создайте четыре производных класса: 
    //President, Security, Manager, Engineer.Переопределите метод
    //Print() для вывода информации, соответствующей
    //каждому типу работника


    public abstract class Worker
    {

        protected string name;
        protected string position;
        protected int salary;

        public abstract void Print();

    }

    public class President : Worker
    {
                
        public President(string name, int salary)
        {

            this.position = "Президент фирмы";
            this.name = name;
            this.salary = salary;

        }
               

        public override void Print()
        {
            Console.WriteLine($"{position} {name} - {salary} рублей\nДумаю, думаю, организовываю!");
        }

    }

    public class Security : Worker
    {

        bool work;

        public Security(bool work, string name, int salary)
        {
            this.work = work;
            this.name = name;
            this.position = "Охраник";
            this.salary = salary;
        }

        public override void Print()
        {
            if (work)
            {

                Console.WriteLine($"{position} {name} - {salary} рублей\nКуда без пропуска?!\nТы не пройдешь!");

            }
            else
            {
                Console.WriteLine($"{position} {name} - {salary} рублей");
                Console.WriteLine("На чиле, на раслабоне");
            }

        }
    }

    public class Manager : Worker
    {

        int numerDepartment;

        public Manager(int numerDepartment, string name, int salary)
        {
            this.numerDepartment = numerDepartment;
            this.name = name;
            this.position = "Манагер";
            this.salary = salary;
        }

        public override void Print()
        {
            Console.WriteLine($"{position} {numerDepartment} отдела {name} - {salary} рублей\nОтчеты должны быть сданы вчера!");
        }
    }

    public class Engineer : Worker
    {

        string special;
        bool error;

        public Engineer(string special, bool error, string name, int salary)
        {
            this.special = special;
            this.error = error;
            this.name = name;
            this.position = "Инжинер научного института имени Большого Взрыва";
            this.salary = salary;
        }

        public override void Print()
        {
            if (error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{position}, {special}, имя {name} - {salary} рублей");
                Console.WriteLine("Внимание!!! Опасность, Взрыв реактора!!!");                
                Console.ForegroundColor = ConsoleColor.White;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{position}, {special}, имя {name} - {salary} рублей\nСоздаем, чиним ядерный реактор");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
