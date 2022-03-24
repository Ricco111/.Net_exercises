using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceAreaTestInterface
{
    public class Circle : IFigure
    {
        private int _r;
        public int R {
            get
            {
                return _r;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Wrong value, must be more than 0");
                }
                _r = value;
            }
        }
        
        const double Pi = 3.14;

        public void GetArea()
        {
            _r = int.Parse(Console.ReadLine());
            Console.WriteLine("Your circle area is: " + ((R*R)*Pi));
        }

        public void GetPerimeter()
        {
            _r = int.Parse(Console.ReadLine());
            Console.WriteLine("Your circle perimeter is: " + (2*Pi*R));
        }
    }
}
