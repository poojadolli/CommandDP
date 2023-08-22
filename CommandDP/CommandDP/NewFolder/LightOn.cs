using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDP.NewFolder
{
   
        public class LightOn : ICommand
        {
            private Light _light;

            public LightOn(Light light)
            {
                _light = light;
            }

            public void Execute()
            {
                _light.TurnOn();
            }
        }
    }

