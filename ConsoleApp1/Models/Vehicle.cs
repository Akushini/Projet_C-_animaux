using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public abstract class Vehicle : IPilotage
    {
        public string Name { get; protected set; }
        public Vehicle()
        {
        }

        public Vehicle(string name)
        {
            Name = name;
        }

        public void Moove()
        {
            throw new NotImplementedException();
        }
    }
}
