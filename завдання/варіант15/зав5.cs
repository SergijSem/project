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
            List<string> server = new List<string>();
            display(server);
        }
        static void add_in_server(List<string> server)
        {
            string id;
            Console.WriteLine("введіть ID:");
            id = Console.ReadLine();
            server.Add(id);
        }
        static void remove_in_server(List<string> server)
        {
            string id;
            int index = 0;
            Console.WriteLine("введіть ID:");
            id = Console.ReadLine();
            foreach (string i in server)
            {
                if (i == id)
                {
                    index = 1;
                }
            }
            if (index == 1)
            {
                server.Remove(id);
                Console.WriteLine("ID видалено");
            }
            else
            {
                Console.WriteLine("це ID - не існує");
            }
        }
        static void print_server(List<string> server)
        {
            Console.WriteLine("ID серверу:");
            foreach (string i in server)
            {
                Console.WriteLine(i);
            }
        }
        static void audit_server(List<string> server)
        {
            int num = 0;
            foreach (string i in server)
            {
                num++;
            }
            if (num > 10)
            {
                Console.WriteLine("помилка!! Сервер перевантажений");
            }
            else
            {
                Console.WriteLine("Сервер в нормі");
            }
        }
        static void display(List<string> server)
        {
            int comand = 0;
            while(comand!=4)
            {
                Console.WriteLine("команди\n1-add\n2-remove\n3-print\n4-stop");
                comand =Convert.ToInt16( Console.ReadLine());
                if(comand==1)
                {
                    add_in_server(server);
                }
                else if(comand==2)
                {
                    remove_in_server(server);
                }
                else if(comand!=3)
                {
                    print_server(server);
                }
                audit_server(server);
            }
        }
     }
   
}