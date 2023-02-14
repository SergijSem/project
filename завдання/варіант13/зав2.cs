using System;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Project
{
    class forms
    {
        static List<anketa> all_anketa = new List<anketa>();
        static void Main()
        {

        }
        static void form()
        {
            Console.WriteLine("Enter minimum point:");
            int min_point=Convert.ToInt16(Console.ReadLine());
            List<anketa> anketas = new List<anketa>();
            foreach (anketa i in all_anketa)
            {
                if(i.poi.average_point>=min_point)
                {
                    anketas.Add(i);
                }
            }
        }
    }
    class anketa
    {
        public string name;
        public string email;
        public string phone;
        public points poi;
    }
    class points
    {
        public int math;
        public int language;
        public int history;
        public int average_point;
    }
}