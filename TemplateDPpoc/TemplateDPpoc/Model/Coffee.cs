using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDPpoc.Model
{
    class Coffee : Beverage
    {
        protected override void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected override void Brew()
        {
            Console.WriteLine("Brewing coffee");
        }

        protected override void PourInCup()
        {
            Console.WriteLine("Pouring coffee into cup");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}
