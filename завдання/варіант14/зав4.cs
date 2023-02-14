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
            hero hero = new hero() { name = "hero",life=5,power=10,speed=4,mind=5};
            hero save_hero=new hero();
            save(hero, save_hero);
        }
        static void save(hero hero, hero save_hero)
        {
            save_hero = hero;
        }
    }
    class hero
    {
        public string name;
        public int life;
        public int power;
        public int speed;
        public int mind;
    }
}