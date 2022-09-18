using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Product product = new Product("Buron", 18.40, "P");
            //Console.WriteLine(product);

            //Teapot teapot = new Teapot();
            //MicrowaveOven microwaveOven = new MicrowaveOven();
            //Car car = new Car();
            //Steamboat steamboat = new Steamboat();
            //Device[] device = new Device[] {teapot, microwaveOven, car, steamboat};

            //foreach(Device dev in device)
            //{

            //    Console.WriteLine(dev.Show());
            //    Console.WriteLine(dev.Desc());
            //    Console.WriteLine(dev.Song());

            //}

            //Violin violin = new Violin();
            //Trombone trombone = new Trombone();
            //Ukulele ukulele = new Ukulele();
            //Violoncello violoncello = new Violoncello();
            //MusicalInstrument[] musical = new MusicalInstrument[] {violin, trombone, ukulele, violoncello};

            //foreach(MusicalInstrument n in musical)
            //{

            //    Console.WriteLine(n.Show());
            //    Console.WriteLine(n.Desc());
            //    Console.WriteLine(n.Sound());
            //    Console.WriteLine(n.History());

            //}

            President president = new President("Генадий Владимирович", 1532456874);
            Security security = new Security(false, "Бородач Александр Родионович", 100);
            Manager manager = new Manager(13, "Джонатан", 100500);
            Engineer engineer = new Engineer("Отдел термоядерных ядерных батареек", true, "засекречено", 800000);
            Worker[] workers = new Worker[] {president, security, manager, engineer};

            foreach( Worker w in workers)
            {
                w.Print();
                Console.WriteLine();
            }

        }
    }
}
