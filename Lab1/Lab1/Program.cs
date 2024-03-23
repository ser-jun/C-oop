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

        }
        static void Main(string[] args)
        {
            Shedule shedule = new Shedule("Учебное заведение", "Адрес");
            Program program = new Program();
            int a = 0;

            while (true)
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
                }
            }
        }
    }
}
