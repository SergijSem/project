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
            List<flower> flowers = new List<flower>();
            int comand=0;
            while (comand != 3)
            {
                Console.WriteLine("команди:\n1-addflower\n2-watering\n3-stop");
                comand=Convert.ToInt32(Console.ReadLine());
                if (comand == 1)
                {
                    addflower(flowers);
                }
                if (comand == 2)
                {
                    watering(flowers);
                }
            }
        }
        static void addflower(List<flower> flowers)
        {
            string name;
            int type;
            Console.WriteLine("введіть назву квітки:");
            name = Console.ReadLine();
            Console.WriteLine("введіть тип:\n1 - не любить вологу\n2 - звичайна\n3 - любить вологу");
            type = Convert.ToInt32(Console.ReadLine());
            if (type == 1 || type == 2 || type == 3)
            {
                flowers.Add(new flower() { name = name, type = type });
            }
            else
            {
                Console.WriteLine("Помилка типу");
            }
        }
        static void watering(List<flower> flowers)
        {
            int water=0;
            foreach (flower i in flowers)
            {
                if(i.type==1)
                {
                    water = 50;
                }
                else if(i.type==2)
                {
                    water = 100;
                }
                else if(i.type==3)
                {
                    water = 130;
                }
                Console.WriteLine(i.name+"підільляти на відсотків: "+water);
            }
        }
    }
    class flower
    {
        public string name;
        public int type;
    }
}