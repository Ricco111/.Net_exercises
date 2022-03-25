using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Desk : Item
    {
        private int Height { get; set; }
        private int Width { get; set; }


        public Desk(int height, int width)
        {
            Height = height;
            Width = width;
        }
    }
}
