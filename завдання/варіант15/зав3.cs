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
           List<set> sets=new List<set>();
            set set1=new set() { gift1="іграшка", gift2="іграшка", gift3="цукерки" };
            addgifts(sets,set1);
            readsets(sets);
        }
        static void addgifts(List<set> sets, set set1)
        {
            int num = -1;
            while (num < 0)
            {
                Console.WriteLine("Скільки створити наборів?");
                num=Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < num; i++)
            {
                sets.Add(set1);
            }
        }
        static void readsets(List<set> sets)
        {
            foreach(set i in sets)
            {
                Console.WriteLine("Набір: " + i.gift1 + "," + i.gift2 + "," + i.gift3);
            }
        }
        }
   
    class set
    {
        public string gift1;
        public string gift2;
        public string gift3;
    }
}
