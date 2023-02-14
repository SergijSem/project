using System;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Project
{
    class program
    {
        static List<house> house = new List<house>();
        static void Main()
        {
            read();
        }
        static void read()
        {
            string com="";
            int comand = 0;
            int comand1 = 0;
            int comand2 = 0;
            int index = 0;
            int num_pets = 0;
            int num_age = 0;
            int middle_age = 0;
            Console.WriteLine("1)показати будинки" +
                "\n2)показати квартири будинку" +
                "\n3)показати тварин в квартирі");
            comand=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("показати тварин? 1)так 2)ні");
            comand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("показати середній вік тварин? 1)так 2)ні");
            comand2 = Convert.ToInt32(Console.ReadLine());
            if (comand == 1)
            {
                foreach (house i in house)
                {
                    Console.WriteLine(i.name);
                    if(comand1==1)
                    {
                        Console.WriteLine("всі тварини: ");
                        foreach (apartment j in i.apartments)
                        {
                            foreach (pet q in j.pets)
                            {
                                Console.WriteLine(q.name + " вік: " + q.age);
                                if (comand2 == 1)
                                {
                                    num_pets++;
                                    num_age += q.age;
                                }
                            }
                            if (comand2 == 1)
                            {
                                middle_age = num_age / num_pets;
                                Console.WriteLine("Середній вік: " + middle_age);
                                num_pets = 0;
                                num_age = 0;
                            }
                        }
                    }
                }
            }
            else if (comand == 2)
            {
                Console.WriteLine("введіть назву будинку:");
                com = Console.ReadLine();
                foreach (house i in house)
                {
                    if (i.name == com)
                    {
                        foreach (apartment j in i.apartments)
                        {
                            Console.WriteLine(j.name);
                            if (comand1 == 1)
                            {
                                Console.WriteLine("всі тварини: ");
                                foreach (pet q in j.pets)
                                {
                                    Console.WriteLine(q.name + " вік: " + q.age);
                                    if (comand2 == 1)
                                    {
                                        num_pets++;
                                        num_age += q.age;
                                    }
                                }
                                if (comand2 == 1)
                                {
                                    middle_age = num_age / num_pets;
                                    Console.WriteLine("Середній вік: " + middle_age);
                                    num_pets = 0;
                                    num_age = 0;
                                }
                            }
                            index = 1;
                        }
                    }
                }
            }
            else if (comand == 2)
            {
                Console.WriteLine("введіть назву будинку:");
                com = Console.ReadLine();
                foreach (house i in house)
                {
                    if (i.name == com)
                    {
                        Console.WriteLine("введіть назву квартири:");
                        com = Console.ReadLine();
                        foreach (apartment j in i.apartments)
                        {
                           if(com==j.name)
                            {
                                foreach(pet q in j.pets)
                                {
                                    Console.WriteLine(q.name + " вік: " + q.age);

                                    if (comand2 == 1)
                                    {
                                        num_pets++;
                                        num_age += q.age;
                                    }
                                   
                                }
                                if (comand2 == 1)
                                {
                                    middle_age = num_age / num_pets;
                                    Console.WriteLine("Середній вік: " + middle_age);
                                    num_pets = 0;
                                    num_age = 0;
                                }
                            }
                        }
                        index = 1;
                    }
                }
            }
            }
    }
    class house
    {
        public string name;
        public List<apartment> apartments = new List<apartment>();
    }
    class apartment
    {
        public string name;
        public List<pet> pets=new List<pet>();
    }
    class pet
    {
        public string name;
        public int age;
    }
}