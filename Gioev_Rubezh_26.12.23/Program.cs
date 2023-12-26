using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gioev_Rubezh_26._12._23.Class1;

namespace Gioev_Rubezh_26._12._23
{
    class Program
    {

        static void Main(string[] args)
        {
            Lesson les1 = new Lesson();
            Lesson les2 = new Lesson();
            Lesson les3 = new Lesson();
            Lesson lesMat = new Lesson("Матан", 1, 0, WeekDays.Monday, "11");
            Lesson lesAlg = new Lesson("Алгебра", 2, 1, WeekDays.Monday, "11");
            Lesson lesAlgPract = new Lesson("Алгебра", 2, 1, WeekDays.Monday, "21");

            Schedule schedule = new Schedule("ФМиКН");
            schedule.Add(les3);
            schedule.Add(les2);
            schedule.Add(les1);
            schedule.Add(lesAlg);
            schedule.Add(lesAlgPract);
            schedule.Add(lesMat);
            Console.WriteLine(schedule);

            schedule.listLesson.Sort();

            Console.WriteLine(schedule);
        }
    }
}
