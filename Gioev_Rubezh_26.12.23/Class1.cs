using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gioev_Rubezh_26._12._23
{
    class Class1
    {
        public enum WeekDays
        {
            Monday,
            Thuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public class Lesson
        {
            public string Label { get; set; }
            public char labelLetter = 'A';
            public int Number { get; set; }
            public int weekNumber { get; set; }
            public WeekDays weekDay { get; set; }
            public string groupNumber { get; set; }

            public Lesson()
            {
                Label = labelLetter.ToString();
                labelLetter++;
                Number = 1;
            }

            public Lesson(string label, int number, int weeknumber, WeekDays weekday, string group)
            {
                Label = label;
                Number = number;
                weekNumber = weeknumber;
                weekDay = weekday;
                groupNumber = group;
            }

            public override string ToString()
            {
                string weekday = "";
                switch (weekDay)
                {
                    case WeekDays.Monday:
                        weekday = "понедельник";
                        break;
                    case WeekDays.Thuesday:
                        weekday = "вторник";
                        break;
                    case WeekDays.Wednesday:
                        weekday = "среда";
                        break;
                    case WeekDays.Thursday:
                        weekday = "четверг";
                        break;
                    case WeekDays.Friday:
                        weekday = "пятница";
                        break;
                    case WeekDays.Saturday:
                        weekday = "суббота";
                        break;
                    case WeekDays.Sunday:
                        weekday = "воскресенье";
                        break;
                }
                string weekInfo = "";
                switch (weekNumber)
                {
                    case (0):
                        weekInfo = "каждую неделю";
                        break;
                    case (1):
                        weekInfo = "первая неделя";
                        break;
                    case (2):
                        weekInfo = "вторая неделя";
                        break;

                }
                return $"{Label}., {Number} пара {weekday}, {groupNumber} группа, {weekInfo}";
            }
        }

        public class Schedule : IComparable<Lesson>
        {
            public string Name { get; set; }
            public List<Lesson> listLesson = new List<Lesson>();

            public Schedule(string name)
            {
                Name = name;
            }

            public void Add(Lesson lesson)
            {
                listLesson.Add(lesson);
            }

            public override string ToString()
            {
                int numb = 1;
                string result = "";
                foreach(var lesson in listLesson)
                {
                    result += ($"{numb}. {lesson.ToString()}\n");
                    numb++;
                }
                return result;
            }

            int IComparable<Lesson>.CompareTo(Lesson other)
            {
                foreach(var lesson in listLesson)
                {
                    if(int.Parse(lesson.groupNumber) < int.Parse(other.groupNumber))
                    {
                        return -1;
                    }
                    else if((int.Parse(lesson.groupNumber) > int.Parse(other.groupNumber)))
                    {
                        return 1;
                    }

                    if(lesson.weekDay < other.weekDay)
                    {
                        return -1;
                    }
                    else if(lesson.weekDay > other.weekDay)
                    {
                        return 1;
                    }

                    if(lesson.Number < other.Number)
                    {
                        return -1;
                    }
                    else if(lesson.Number > other.Number)
                    {
                        return 1;
                    }

                    if(lesson.weekNumber < other.weekNumber)
                    {
                        return -1;
                    }
                    else if(lesson.weekNumber > other.weekNumber)
                    {
                        return 1;
                    }
                }
                return 0;
            }
        }
    }
}
