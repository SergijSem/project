using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Project
{
    class program
    {
        
        static void Main()
        {
            List<zauc> director = new List<zauc>();
            fundraising(director);
        }
        static void fundraising(List<zauc> director)
        {
            int money=-1;
            int num_parents = 0;
            int allmoney = 0;
            while (money < 0)
            {
                Console.WriteLine("Яку суму збираємо з кожного батька?");
                money=Convert.ToInt32(Console.ReadLine());
            }

            foreach(zauc i in director)
            {
                foreach(class_teacher j in i.teachers)
                {
                    foreach(string q in j.parents)
                    {
                        num_parents++;
                    }
                }
            }
            allmoney=num_parents*money;
            Console.WriteLine("Отримані кошти: " + allmoney + " грн.");
        }
    }
    class zauc
    {
       public List<class_teacher> teachers;
    }
        class class_teacher
    {
        public string clas;
        public List<string> parents;
    }
}