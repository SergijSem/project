using System;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Project
{
    class program
    {
        static List<accessory> accessorys = new List<accessory>();
        static void Main()
        {
            addleash();
            addleash();
            read();
        }
        static void addleash()
        {
            int comand1 = 0;
            int comand2 = 0;
            int comand3 = 0;
            string type = "";
            string size= "";
            Console.WriteLine("випустити: 1)нашийники 2)намордники  3)поводки");
            comand1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("розмір: 1)S 2)M 3)L");
            comand2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("кількість?");
            comand3 = Convert.ToInt16(Console.ReadLine());
            if (comand1 == 1 || comand1 == 2 || comand1 == 3)
            {
                if (comand2 == 1 || comand2 == 2 || comand2 == 3)
                {
                    if (comand3 > 0)
                    {
                        if(comand1==1)
                        {
                            type = "нашийник";
                        }
                        else if(comand1 == 2)
                        {
                            type = "намордник";
                        }
                        else if(comand1==3)
                        {
                            type = "поводок";
                        }
                        if (comand2 == 1)
                        {
                            size = "S";
                        }
                        else if (comand2 == 2)
                        {
                            size = "M";
                        }
                        else if (comand2 == 3)
                        {
                            size = "L";
                        }
                        for (int i = 0; i < comand3; i++)
                        {
                            accessorys.Add(new accessory() { type = type, size = size });
                        }
                    }
                }
            }
        }
        static void read()
        {
            foreach(accessory i in accessorys)
            {
                Console.WriteLine(i.type + " розмір: " + i.size);
            }
        }
    }
    class accessory
    {
        public string type;//1)нашийники 2)намордники  3)поводки
        public string size;//1)S 2)M 3)L
    }
}