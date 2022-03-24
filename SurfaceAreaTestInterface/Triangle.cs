using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurfaceAreaTestInterface
{
    public class Triangle : IFigure
    {
        private int _height;
        private int _base;
        private int _sideC;
        private int _sideB;
        public int Height {
            get
            {
                return _height;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Wrong value, must be more than 0");
                }
                _base = value;
            }
        }
        public int Base {
            get
            {
                return _base;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Wrong value, must be more than 0");
                }
                _base = value;
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

        public int SideC
        {
            get
            {
                return _sideC;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Wrong value, must be more than 0");
                }
                _sideC = value;
            }
        }

        public void GetArea()
        {
            _height = int.Parse(Console.ReadLine());
            _base = int.Parse(Console.ReadLine());
            Console.WriteLine("Your triangle area is: " + ((Height * Base)/2));
        }

        public void GetPerimeter()
        {
            _sideC = int.Parse(Console.ReadLine());
            _base = int.Parse(Console.ReadLine());
            _sideB = int.Parse(Console.ReadLine());
            Console.WriteLine("Your triangle perimeter is: " + (Base + SideB + SideC));
        }
    }
}
