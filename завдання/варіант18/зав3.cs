using System;
using System.Diagnostics.Metrics;
using System.Net.Sockets;
using System.Reflection;

namespace Project
{
    class program
    {
        static List<ticket> tickets = new List<ticket>();
        static void Main()
        {
            List<int> places = new List<int>();
            int place_in_line;//кількість місць в ряду 
            int num_place;
            int num_line;
            Console.WriteLine("кількість рядів:");
            num_line = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кількість місць в ряду");
            place_in_line = Convert.ToInt32(Console.ReadLine());
            num_place = num_line * place_in_line + 1;
            for (int i = 0; i < num_place; i++)
            {
                places.Add(i + 1);
            }
            addticket(place_in_line,  num_place, places);
            readticket(place_in_line);
        }
        static void addticket(int place_in_line, int num_place, List<int> places)
        {
            int num_ticket = 0;
            int place;
            int line;
            Console.WriteLine("Яку кількість квитків купуєте?");
            num_ticket = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num_ticket; i++)
            {
                if (places[0] == num_place)
                {
                    Console.WriteLine("квидки закінчились!");
                    break;
                }
                place = places[0];
                if (place % place_in_line == 0)
                {
                    line = place / place_in_line;
                }
                else
                {
                    line = place / place_in_line + 1;
                }
                tickets.Add(new ticket() { line = line, place = place });
                places.Remove(places[0]);
                Console.WriteLine("видано квиток: ряд: " + line + " місце: " + place);
            }
        }
        static void readticket(int place_in_line)
        {
            Console.WriteLine("Видано квитки:");
            foreach (ticket ticket in tickets)
            {
                Console.WriteLine(ticket.line +" "+ ticket.place);
            }
        }
    }

    class ticket
    {
        public int line;
        public int place;
    }
}