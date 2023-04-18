using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Chien : Animal
    {

        public Chien()
        {
        }

        public Chien(string name, string rarity)
        {
            Name = name;
            Rarity = rarity;
        }
        public override void Moove()
        {
            Console.WriteLine("Le griffon a un vol agile");
        }
        new public void Sleep()
        {
            Console.WriteLine("Le griffon dort dans des cavernes isolées");
        }
    }
}
