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

        private static int LastId = 0;

        public Animal()
        {
        }

        public Animal(string name, string rarity)
        {
            Name = name;
            Rarity = rarity;
            Id = ++LastId;   
        }

        public abstract void Moove();

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }
    }
}

