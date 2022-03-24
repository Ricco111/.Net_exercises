using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceAreaTestInterface
{
    public class Rectangle : IFigure
    {
        private int _sideA;
        private int _sideB;

        public int SideA { 
            get{
                return _sideA;
            }
            private set{
                if (value <= 0)
                {
                    Console.WriteLine("Wrong value, must be more than 0");
                }
                _sideA = value;
            }
        }
        public int SideB
        {
            get
            {
                return _sideB;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Wrong value, must be more than 0");
                }
                _sideB = value;
            }
        }

        public void GetArea()
        {
            _sideA = int.Parse(Console.ReadLine());
            _sideB = int.Parse(Console.ReadLine());
            Console.WriteLine("Your rectangle area is: "+ (SideA * SideB));
        }



        public void GetPerimeter()
        {
            _sideA = int.Parse(Console.ReadLine());
            _sideB = int.Parse(Console.ReadLine());
            Console.WriteLine("Your rectangle perimeter is: " + ((SideA + SideB)*2));
        }
 
    }
}
