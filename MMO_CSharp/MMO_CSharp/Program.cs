using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zu deinem ersten MMO");
            Console.WriteLine(" ");
            List<Units> units = new List<Units>();
            units.Add(new Tank("Axt", "Olaf", "diamond Armor", 25, "Stone of Life", "Mensch", 2.5, 380));
            units.Add(new Healer("Wand", "Luce", 15, "Stone of Wisdom", "Fee", 4, 220));
            units.Add(new Wizard("Magical_Abilities", "Gregor A. Gregorius", "iron armor", 60, "Stone of Magic", "Erleuchteter",20, 250));
            units.Add(new Archer("Bow", "Lora", "wodden armor", 55, "Stone of Air", "Elbe", 18, 290));
            Console.ReadLine();
        }

    }
}
