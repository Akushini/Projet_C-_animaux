using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Dog : Animal
    {

        public Dog()
        {
        }

        public Dog(string name, string rarity, string specie, int id)
        {
            Name = name;
            Rarity = rarity;
            Specie = specie;
            Id = id;
        }

        public override void Moove()
        {
            Console.WriteLine("12 m au sol");
        }
        public override void Sleep()
        {
            Console.WriteLine("12 à 14h par jour");
        }
    }
}
