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
        }
        public void Edit(string newName, string newDayOfWeek, string newTime)
        {
            name = newName;
            dayOfWeek = newDayOfWeek;
            time = newTime;
        }

    }
}
