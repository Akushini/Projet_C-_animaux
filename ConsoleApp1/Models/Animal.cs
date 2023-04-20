using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public abstract class Animal
    {
        public string Name { get; protected set; }
        public string Rarity { get; protected set; }
        public int Id { get; protected set; }
        public string Specie { get; protected set; }

        public Animal()
        {
        }

        public Animal(string name, string rarity, string specie, int id)
        {
            Name = name;
            Rarity = rarity;
            Specie = specie;
            Id = id;
        }

        public abstract void Moove();

        public abstract void Sleep();
    }
}

