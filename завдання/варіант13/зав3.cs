using System;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Project
{
    class lesson
    {
        static void Main()
        { 
            deck_creation();
        }
        static void deck_creation()
        {
            List<cards> deck = new List<cards>();
            string[] suits=new string[] { "hearts", "cross", "picot", "tambourine" };
            string[] rangs = new string[] { "6","7","8","9","10","V","Q","K","A" };
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < rangs.Length; j++)
                {
                    deck.Add(new cards() { rang = rangs[j], suit = suits[i] });
                }
            }
            int a = 0;
            foreach(cards i in deck)
            {
                Console.Write(i.rang+"."+i.suit+" ");
                a++;
                if(a==9)
                {
                    a = 0;
                    Console.WriteLine();
                }
            }
        }
    }
    class  cards
    {
        public string rang;
        public string suit;
    }
}