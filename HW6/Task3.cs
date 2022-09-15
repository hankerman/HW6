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

    

}
