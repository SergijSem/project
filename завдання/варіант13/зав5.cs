using System;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Project
{
    class lesson
    {
        static void Main()
        {
            student stud = new student();
            Console.WriteLine("Enter name:");
            stud.name = Console.ReadLine();
            Console.WriteLine("Enter number of lesson:");
            stud.num_lesson =Convert.ToInt16( Console.ReadLine());
            state(stud);
        }
        static void state(student stud)
        {
           int interest=5*stud.num_lesson;
            if(interest>100)
            {
                interest = 100;

            }
            if(interest<60)
            {
                stud.state_point = 2;
            }
            else if(interest<80)
            {
                stud.state_point = 3;
            }
            else if(interest<95)
            {
                stud.state_point = 4;
            }
            else
            {
                stud.state_point = 5;
            }
            Console.WriteLine("Potential assessment: "+stud.state_point);
        }
    }
    class student
    {
        public string name;
        public int num_lesson;
        public int state_point;
    }
}