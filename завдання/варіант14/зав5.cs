using System;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Project
{
    class program
    {
        static void Main()
        {
            int time;// time in minutdes
            time=Convert.ToInt32(Console.ReadLine());
            cleaning(time);
        }
        static void cleaning(int time)
        {
            if(time<60)
            {
                Console.WriteLine("легке прибирання (скласти розкидані речі, підмести підлогу)");
            }
            else if (time < 180)
            {
                Console.WriteLine("звичайне прибирання (витерти пил, використати пилосос)");
            }
            else 
            {
                Console.WriteLine("генеральне прибирання (вологе прибирання підлоги, а також миття вікон)");
            }
        }
    }
}