using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO_CSharp
{
    public class Tank : Units
    {
        public Tank(string weapon, string name, string armor, double damage, string indiviudal_item, string roots,
            double range_ofDamage, double health_points)
        {
            Weapon = weapon;
            Name = name;
            Armor = armor;
            Damage = damage;
            Individual_item = indiviudal_item;
            Roots = roots;
            Range_ofDamage = range_ofDamage;
            Health_Points = health_points;
            Max_Health_Points = health_points;

        }
    }
}
