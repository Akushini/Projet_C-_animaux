using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Dragon : Animal, IPilotage
    {

        public Dragon()
        {
        }

        public Dragon(string name, string rarity)
        {
            Name = name;
            Rarity = rarity;
        }

        public override void Moove()
        {
            Console.WriteLine("Le dragon vol vite, mais manoeuvre avec difficulté");
        }
        public new void Sleep()
        {
            Console.WriteLine("Un dragon dort sur un tas d'or");
        }
    }
}
