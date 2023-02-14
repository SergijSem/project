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
            create_drink();
        }
        static void create_drink()
        {
            int comand1 = 0;
            int comand2 = 0;    
            int comand3 = 0;
            while (comand1 > 4 || comand1 <= 0)
            {
                Console.WriteLine("який напій бажаєте:\n1-чай\n2-каву\n3-какао\n4-стоп");
                comand1 = Convert.ToInt16(Console.ReadLine());
            }
            while (comand2 >= 10 || comand2 <= 0)
            {
                Console.WriteLine("скільки ложок цукру?");
                comand2 = Convert.ToInt16(Console.ReadLine());
            }
            if (comand1 == 1)
            {
                Console.WriteLine("бажаєте лимон? \n1-так\n2-ні");
            }
            else
            {
                Console.WriteLine("бажаєте молока? \n1-так\n2-ні");
            }
            comand3 = Convert.ToInt16(Console.ReadLine());
            if (comand1 == 1||comand1==2||comand3==3)
            {
                Console.WriteLine("Ваш напій:");
                if(comand1 == 1)
                {
                    Console.Write(" чай");
                    if(comand3==1)
                    {
                        Console.Write(" з лимоном ");
                    }
                }
                else 
                {
                    if (comand1 == 2)
                    {
                        Console.Write("кава");
                    }
                    else
                    {
                        Console.Write("какао");
                    }
                    if (comand3 == 1)
                    {
                        Console.Write(" з молоком ");
                    }
                }
                if(comand2==0)
                {
                    Console.Write(" без цукру ");
                }
                else
                {
                    Console.Write(","+comand2+" ложки цукру");
                }
            }
            else if(comand1==4)
            {
                Console.WriteLine("Ви нічого не замовили");
            }
        }
       
        
    }
}
