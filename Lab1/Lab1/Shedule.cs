using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab1
{
    internal class Shedule
    {

        private string educationalInstitutionNumber;
        private string address;
        private string elem;
        private List<Lesson> lessons = new List<Lesson>();
        private List<Shedule> shedules = new List<Shedule>();

        public Shedule(string educationalInstitutionNumber, string address)
        {
            this.educationalInstitutionNumber = educationalInstitutionNumber;
            this.address = address;
        }
        private bool CheckNumber(string num)
        {
            return int.TryParse(num, out _);
        }
        private bool CheckTime(string time)
        {
            string pattern = @"^(?:[01]\d|2[0-3]):[0-5]\d$";
            return Regex.IsMatch(time, pattern);
        }
        private bool CheckDayOfWeek(string day)
        {
            switch (day.ToLower())
            {
                case "понедельник":

                case "вторник":

                case "среда":

                case "четверг":

                case "пятница":

                case "суббота":

                case "воскресенье":

                    return true;
                default: return false;
            }
        }
        private void EditS(string newEducationalInstitutionNumber, string newAddress)
        {
            educationalInstitutionNumber = newEducationalInstitutionNumber;
            address = newAddress;
        }
        public void Add(Shedule specShedule)
        {
            while (true)
            {
                if (shedules.Count == 0)
                {
                    Console.WriteLine("Сначала добавьте расписание!");
                    break;
                }
                else
                {
                    Console.WriteLine("Введите название предмета");
                    string name = Console.ReadLine();

                    Console.WriteLine("Введите день недели");
                    string dayOfWeek = Console.ReadLine();
                    if (!CheckDayOfWeek(dayOfWeek))
                    {
                        Console.WriteLine("День недели введен некорректно");
                        continue;
                    }

                    Console.WriteLine("Введите время");
                    string time = Console.ReadLine();
                    if (!CheckTime(time))
                    {
                        Console.WriteLine("Время введено некорректно");
                        continue;
                    }

                    Lesson newLesson = new Lesson(name, dayOfWeek, time);
                    specShedule.lessons.Add(newLesson);

                    break;
                }
            }
        }
        public void RemoveFromShedule()
        {
            Console.WriteLine("Введите название предмета, который хотите удалить");
            elem = Console.ReadLine();
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i].GetName() == elem)
                {
                    lessons.RemoveAt(i);
                }
            }
            elem = null;
        }
        public void Show()
        {
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"Название: {lessons[i].GetName()}, День недели: {lessons[i].GetDayOfWeek()}, Время: {lessons[i].GetTime()}");
            }
        }
        public void EditLesson()
        {
            while (true)
            {
                Console.WriteLine("Введите название предмета который хотите редактировать");
                elem = Console.ReadLine();
                Console.WriteLine("Введите новые данные для занятия");
                Console.WriteLine("Введите новое название для предмета");
                string newName = Console.ReadLine();
                Console.WriteLine("Введите новый день недели");
                string newDayOfWeek = Console.ReadLine();
                if (!CheckDayOfWeek(newDayOfWeek))
                {
                    Console.WriteLine("День недели введен некорректно");
                    continue;
                }
                Console.WriteLine("Введите новое время");
                string newTime = Console.ReadLine();
                if (!CheckTime(newTime))
                {
                    Console.WriteLine("Время введено некорректно");
                    continue;
                }
                for (int i = 0; i < lessons.Count; i++)
                {
                    if (lessons[i].GetName() == elem)
                    {
                        lessons[i].Edit(newName, newDayOfWeek, newTime);
                    }
                }
                elem = null;
                break;
            }
        }
        public void Add()
        {
            while (true)
            {
                Console.WriteLine("Введите номер учебного заведения ");
                educationalInstitutionNumber = Console.ReadLine();
                if (!CheckNumber(educationalInstitutionNumber))
                {
                    Console.WriteLine("Номер введен некорректно");
                    continue;
                }
                Console.WriteLine("Введите адресс учебного заведения ");
                address = Console.ReadLine();
                Shedule shedule = new Shedule(educationalInstitutionNumber, address);
                shedules.Add(shedule);
                break;
            }
        }
        public void ShowShedule()
        {
            for (int i = 0; i < shedules.Count; i++)
            {
                Console.WriteLine($"Номер учебного заведения: {shedules[i].educationalInstitutionNumber}, " +
                    $"Адресс учебного заведения: {shedules[i].address}");
            }
        }
        public void RemoveShedule()
        {

            Console.WriteLine("Введите адресс учебного заведения которое хотите удалить");
            elem = Console.ReadLine();

            for (int i = 0; i < shedules.Count; i++)
            {
                if (shedules[i].address == elem)
                {
                    shedules.RemoveAt(i);
                }
            }
            elem = null;

        }
        public void EditShedule()
        {
            while (true)
            {
                Console.WriteLine("Введите адресс учебного заведения которое чтобы редактировать расписание");
                elem = Console.ReadLine();
                for (int i = 0; i < shedules.Count; i++)
                {
                    if (shedules[i].address == elem)
                    {
                        Console.WriteLine("Введите новый номер учебного заведения ");
                        string newNumber = Console.ReadLine();
                        if (!CheckNumber(newNumber))
                        {
                            Console.WriteLine("Номер введен некорректно");
                        }
                        Console.WriteLine("Введите новый адресс учебного заведения ");
                        string newAddress = Console.ReadLine();
                        shedules[i].EditS(newNumber, newAddress);
                    }


                }
                elem = null;
            }
        }
    }
}
