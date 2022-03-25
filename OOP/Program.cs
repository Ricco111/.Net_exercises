
using System;

namespace OOP
{
    class Program
    {
        public static IManager GetManager()
        {
            return new FileManager();
        }
        static void Main(string[] args)
        {     
            var myLamp = new Lamp(200, 100);
            myLamp.LightItSelf();
            
            var myLamp2 = new Lamp(300, 150);
            myLamp2.LightItSelf();

            var manager = GetManager();
            manager.SaveLamp(myLamp);
        }
    }

}
