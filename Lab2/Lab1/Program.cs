using System;

namespace Lab1
{
    internal class Program
    {
        public void Menu()
        {
            Console.WriteLine("1-Добавить в расписание");
            Console.WriteLine("2-Просмотреть");
            Console.WriteLine("3-Удалить");
            Console.WriteLine("4-Редактировать");
            Console.WriteLine("5-Добавить расписание");
            Console.WriteLine("6-Просмотреть список расписаний");
            Console.WriteLine("7-Удалить расписание");
            Console.WriteLine("8-Редактировать расписание");
            Console.WriteLine("9-Продемонстрировать работу конструктора копирования");
            Console.WriteLine("10-Вызов конструктора перемещения");
            Console.WriteLine("11-Конструктор копирования");
            Console.WriteLine("0-Выход=вызов деструктора");
        }
        static void Main(string[] args)
        {

            Shedule shedule = new Shedule();
            Shedule shedule1 = new Shedule();
            Program program = new Program();

            Lesson lesson = new Lesson();

            int a = 1;

            while (a != 0)
            {
                program.Menu();
                a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        shedule.Add(shedule);
                        break;

                    case 2:
                        shedule.Show();
                        break;
                    case 3:

                        shedule.RemoveFromShedule();
                        break;
                    case 4:
                        shedule.EditLesson();
                        break;
                    case 5:
                        shedule.Add();

                        break;
                    case 6:
                        shedule.ShowShedule();
                        break;
                    case 7:
                        shedule.RemoveShedule();
                        break;
                    case 8:
                        shedule.EditShedule();
                        break;
                    case 9:

                        Console.WriteLine("Введите количество копий:");
                        int copyCount = Convert.ToInt32(Console.ReadLine());
                        shedule.CreateCopies(shedule, copyCount);
                        break;
                    case 10:
                        shedule.UseMoveConstructor(shedule1, shedule);
                        break;
                    case 11:
                        Console.WriteLine("Введите количество копий урока:");
                        int lessonCopyCount = Convert.ToInt32(Console.ReadLine());
                        shedule.CreateCopiesOfLessons(lesson, lessonCopyCount);
                        break;

                }
                GC.Collect();

            }

        }

    }
}

