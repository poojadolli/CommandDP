using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDPpoc.Model
{
    abstract class Beverage
    {
        public void PrepareBeverage()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void BoilWater();
        protected abstract void Brew();
        protected abstract void PourInCup();
        protected abstract void AddCondiments();
    }
}
