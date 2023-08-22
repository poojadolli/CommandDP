using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDPpoc.Model
{
    class Tea : Beverage
    {
        protected override void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void PourInCup()
        {
            Console.WriteLine("Pouring tea into cup");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}

