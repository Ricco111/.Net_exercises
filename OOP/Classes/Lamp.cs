using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    class Lamp : Item
    {
        private int _power;  // or mPower (members)
        
        public int Power 
        {
            get
            {
                return _power;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Wrong value");
                    return;
                }
                _power = value;
            }                
        }

        public void LightItSelf()
        {
            Console.WriteLine(Height);
            Console.WriteLine(Power);
        }

        public Lamp(int height, int power)
        {
            Height = height;
            Power = power;
        }
    }
}
