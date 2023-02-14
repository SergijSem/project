using System;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Project
{
    class library
    {
        static void Main()
        {
            List <string> logins=new List<string>();
            take_book(logins);
        }
        static void take_book(List<string> logins)
        {
            string com = "";
            string log;
            int flag = 0;
            int flag1 = 0;
            while (com == "yes" || com == "no")
            {
                Console.WriteLine("you have a login?\n-yes \n-no");
                com = Console.ReadLine();
            }
            if (com == "yes")
            {
                while (flag1 == 0)
                {
                    Console.WriteLine("Enter login:");
                    log = Console.ReadLine();
                    foreach (string s in logins)
                    {
                        if (s == log)
                        {
                            flag = 1;
                        }
                    }
                    if (flag == 1)
                    {
                        Console.WriteLine("the book can be published");
                        flag1 = 1;
                    }
                    else
                    {
                        Console.WriteLine("login does not exist\n-0)enter again\n-2)create a new login\n-3)exit");
                        while (flag1 != 1 && flag1 != 2 && flag1 != 3)
                        {
                            flag1 = Convert.ToInt32(Console.ReadLine);
                        }
                        if (flag1==1)
                        {
                            flag1 = 0;
                        }
                    }
                }
            } 
            if (com == "no"||flag1==2)
            {
                com = "";
                Console.WriteLine("want to create a login?\n-yes \n-no");
                while (com == "yes" || com == "no")
                {
                    com=Console.ReadLine();
                }
                if (com=="no")
                {
                    Console.WriteLine("");
                }
                else if(com=="yes")
                {
                    while (flag1 == 0)
                    {
                        Console.WriteLine("Enter login:");
                        log = Console.ReadLine();
                        foreach (string s in logins)
                        {
                            if (s == log)
                            {
                                flag = 1;
                            }
                        }
                        if (flag == 1)
                        {
                            logins.Add(log);
                            Console.WriteLine("the book can be published");
                            flag1 = 1;
                        }
                        else
                        {
                            Console.WriteLine("login exists. Enter another:");
                        }
                    }
                }
            }
        }
    }
}