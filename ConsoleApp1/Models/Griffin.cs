using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Griffin : Animal, IPilotage, IFlying
    {

        public Griffin()
        {
        }

        public Griffin(string name, string rarity, string specie, int id)
        {
            Name = name;
            Rarity = rarity;
            Specie = specie;
            Id = id;
        }

        public void Fly()
        {
            Console.WriteLine("21 m en vol");
        }

        public override void Moove()
        {
            Console.WriteLine("9 m au sol");
        }
        public override void Sleep()
        {
            Console.WriteLine("10 à 12 heures par jour");
        }
    }
}
