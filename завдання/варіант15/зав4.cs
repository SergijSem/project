using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Xml.Linq;

namespace Project
{
    class program
    {
        static void Main()
        {
            hero hero = new hero();
            new_hero(hero);
        }
        static void new_hero(hero hero)
        {
            int comand = 0;
            hero type1 = new hero() { type="маг",life=75 ,power=5 ,speed=4, mind=10};
            hero type2 = new hero() { type = "воїн" ,life = 90, power = 8, speed = 8, mind = 5};
            hero type3 = new hero() { type = "шахтар", life = 10, power = 10, speed = 6, mind = 0};
            while (comand != 1 && comand != 2 && comand != 3)
            {
                Console.WriteLine("Вибрати персонажа:\n1-маг\n2-воїн\n3-шахтар");
                comand=Convert.ToInt32(Console.ReadLine());
            }
            if(comand == 1)
            {
                hero=type1 ;
            }
            else if(comand == 2)
            {
                hero = type2;
            }
            else
            {
                hero = type3;
            }
            Console.WriteLine("Обрано клас:"+hero.type);
        }
     
    }
    class hero
    {
        public string type;
        public int life;
        public int power;
        public int speed;
        public int mind;
    }
}