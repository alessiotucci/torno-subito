using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system_design
{
    internal class Autobus : Veicolo
    {
        public Autobus() : base(99){}

        public override void Alzati()
        {
            // we created a override method to see the LISKOV principle
            base.Alzati();
            Console.WriteLine("mi sono alzato");
        }
    }
}
