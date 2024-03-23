using System;
using System.Collections.Generic;

namespace Lab1
{
    internal class Lesson
    {
        private string name;
        private string dayOfWeek;
        private string time;
        public string GetName() { return name; }
        public string GetDayOfWeek() { return dayOfWeek; }
        public string GetTime() { return time; }

        public Lesson(string Name, string DayOfWeek, string Time)
        {
            name = Name;
            dayOfWeek = DayOfWeek;
            time = Time;
            Console.WriteLine("Вызван конструктор с параметрами");
        }
        public Lesson()
        {
            this.name = null;
            this.dayOfWeek = null;
            this.time = null;
            Console.Write("Вызван конструктор без парметров\n");
        }
        public Lesson(Lesson lesson) 
        { 
        name=lesson.name;
        dayOfWeek=lesson.dayOfWeek;
        time=lesson.time;
            Console.WriteLine("Вызван конструктор копирования");
        }
        public void Edit(string newName, string newDayOfWeek, string newTime)
        {
            name = newName;
            dayOfWeek = newDayOfWeek;
            time = newTime;
        }
       
    }
}
