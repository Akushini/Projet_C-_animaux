using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Dragon : Animal, IPilotage, IFlying
    {

        public Dragon()
        {
        }

        public Dragon(string name, string rarity, string specie, int id)
        {
            Name = name;
            Rarity = rarity;
            Specie = specie;
            Id = id;
        }

        public void Fly()
        {
            Console.WriteLine("60 m en vol");
        }

        public override void Moove()
        {
            Console.WriteLine("12 m au sol");
        }
        public override void Sleep()
        {
            Console.WriteLine("14 à 16h par jour");
        }
    }
}
