using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MMO_CSharp
{
    public class Healer :Units
    {
        public Healer(string weapon, string name,  double damage, string indiviudal_item, string roots,double range_ofDamage,
            double health_points)
        {
            Weapon = weapon;
            Name = name;
            
            Damage = damage;
            Individual_item = indiviudal_item;
            Roots = roots;
            Range_ofDamage = range_ofDamage;
            Health_Points  = health_points;
            Max_Health_Points = health_points;

          
        }
        public void Healing(Units character)
        {
            if (Max_Health_Points < Health_Points )
            {
                
            }
        }
    }
}
