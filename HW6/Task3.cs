using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{

    //    Задание 3
    //Создать базовый класс «Музыкальный инструмент» 
    //и производные классы «Скрипка», «Тромбон», «Укулеле», 
    //«Виолончель». С помощью конструктора установить имя
    //каждого музыкального инструмента и его характеристики.
    //Реализуйте для каждого из классов методы:
    //■ Sound — издает звук музыкального инструмента
    //(пишем текстом в консоль);
    //■ Show — отображает название музыкального инструмента;
    //■ Desc — отображает описание музыкального инструмента;
    //■ History — отображает историю создания музыкального инструмента.

    public abstract class MusicalInstrument
    {

        public abstract string Sound();
        public abstract string Show();
        public abstract string Desc();
        public abstract string History();

    }

    public class Violin : MusicalInstrument
    {
        public override string Desc()
        {
            return "Корпус, гриф, 4 струны и смычок";
        }

        public override string History()
        {
            return "https://ru.wikipedia.org/wiki/Скрипка";
        }

        public override string Show()
        {
            return "Скрипка";
        }

        public override string Sound()
        {
            return "начало произведения времена года вивальди";
        }
    }

    public class Trombone : MusicalInstrument
    {
        public override string Desc()
        {
            return "Медный духовой инструмент";
        }

        public override string History()
        {
            return "https://ru.wikipedia.org/wiki/Тромбон";
        }

        public override string Show()
        {
            return "Тромбон";
        }

        public override string Sound()
        {
            return "Звуки джаза";
        }
    }

    public class Ukulele : MusicalInstrument
    {
        public override string Desc()
        {
            return "Маленькая гитара";
        }

        public override string History()
        {
            return "https://ru.wikipedia.org/wiki/Укулеле";
        }

        public override string Show()
        {
            return "Укулеле";
        }

        public override string Sound()
        {
            return "Гавайская мелодия";
        }
    }

    public class Violoncello : MusicalInstrument
    {
        public override string Desc()
        {
            return "Большая скрипка на которой играют сидя, а не с плеча как на скрипке";
        }

        public override string History()
        {
            return "https://ru.wikipedia.org/wiki/Виолончель";
        }

        public override string Show()
        {
            return "Виолончель";
        }

        public override string Sound()
        {
            return "низкий скрипучий, но при этом нежный звук";
        }
    }

}
