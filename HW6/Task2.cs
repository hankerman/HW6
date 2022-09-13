using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    public abstract class Device
    {

        public abstract string Song();
        public abstract string Show();
        public abstract string Desc();

    }

    public class Teapot : Device
    {
        public override string Desc()
        {
            return "Кипятит воду";
        }

        public override string Show()
        {
            return "Чайник";
        }

        public override string Song()
        {
            return "\"Свистит от закипания\"";
        }
    }

    public class MicrowaveOven : Device
    {
        public override string Desc()
        {
            return "Греет еду";
        }

        public override string Show()
        {
            return "Микроволновая печь";
        }

        public override string Song()
        {
            return "Дзьнь";
        }
    }

    public class Car : Device
    {
        public override string Desc()
        {
            return "Возит людей";
        }

        public override string Show()
        {
            return "Автомобиль";
        }

        public override string Song()
        {
            return "Бип - бип блин";
        }
    }

    public class Steamboat : Device
    {
        public override string Desc()
        {
            return "Двигается по воде и плохо по земле";
        }

        public override string Show()
        {
            return "Пароход";
        }

        public override string Song()
        {
            return "Ту - ту";
        }
    }

}
