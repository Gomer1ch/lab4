using System;

namespace Лаба_4_задание_1
{
    class Time  //Класс для представления времени
    {
        private int hours; //Часы
        public int Hours
        {
            set
            {
                if (value > 23 | value < 0) //Проверка на допустимость введенных значений
                {
                    Console.WriteLine("Несуществующее значение часов");
                }
                else
                {
                    hours = value;
                }
            }
            get { return hours; }
        }
        private int minutes; //Минуты
        public int Minutes
        {
            set
            {
                if (value > 59 | value < 0) //Проверка на допустимость введенных значений
                {
                    Console.WriteLine("Несуществующее значение минут");
                }
                else
                {
                    minutes = value;
                }
            }
            get { return minutes; }
        }
        private int seconds; //Секунды
        public int Seconds
        {
            set
            {
                if (value > 59 | value < 0) //Проверка на допустимость введенных значений
                {
                    Console.WriteLine("Несуществующее значение секунд");
                }
                else
                {
                    seconds = value;
                }
            }
            get { return seconds; }
        }
        public Time() { hours = 0; minutes = 0; seconds = 0; }
        public Time(int s) { hours = 0; minutes = 0; seconds = s; }
        public Time(int s, int m) { hours = 0; minutes = m; seconds = s; }
        public Time(int s, int m, int h) { hours = h; minutes = m; seconds = s; }
        public void ChangeTime(int h, int m, int s) //Метод добавления времени
        {
            if (h > 23) h %= 24;
            if (Hours + h >= 24) Hours += h - 24;
            else Hours += h;
            if (Minutes + m >= 60) { Hours ++; Minutes += m - 60; }
            else Minutes += m;
            if (Seconds + s >= 60) { Minutes++; Seconds += s - 60; }
            else Seconds += s;
        }
        public void GetInfo() //Метод вывода данных 
        {
            Console.WriteLine($"Часы: {hours}, минуты: {minutes}, секунды: {seconds}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int h, m, s;
            Console.WriteLine("Введите данные");
            Time vremya = new Time(); //Создание объекта класса
            Console.WriteLine("Введите кол-во часов:");
            try { vremya.Hours = Convert.ToInt32(Console.ReadLine()); } catch { vremya.Hours = -1; }
            Console.WriteLine("Введите кол-во минут:");
            try { vremya.Minutes = Convert.ToInt32(Console.ReadLine()); } catch { vremya.Minutes = -1; }
            Console.WriteLine("Введите кол-во секунд:");
            try { vremya.Seconds = Convert.ToInt32(Console.ReadLine()); } catch { vremya.Seconds = -1; }
            vremya.GetInfo();
            Console.WriteLine("\nДобавте значения");
            Console.WriteLine("Введите кол-во часов:");
            try { h = Convert.ToInt32(Console.ReadLine()); } catch { h = 0; Console.WriteLine("Несуществующее значение часов"); }
            Console.WriteLine("Введите кол-во минут:");
            try { m = Convert.ToInt32(Console.ReadLine()); } catch { m = 0; Console.WriteLine("Несуществующее значение минут"); }
            Console.WriteLine("Введите кол-во секунд:");
            try { s = Convert.ToInt32(Console.ReadLine()); } catch { s = 0; Console.WriteLine("Несуществующее значение секунд"); }
            vremya.ChangeTime(h, m, s);
            vremya.GetInfo();
            Console.ReadKey();
        }
    }
}
