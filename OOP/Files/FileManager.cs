using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class FileManager : IManager
    {

        public void SaveLamp(Lamp lamp)
        {
            var path = "lamps.txt";
            var content = "Lamp: " + "Height - " + lamp.Height + " Power - " + lamp.Power;
            File.WriteAllText(path, content);
        }
    }
}
