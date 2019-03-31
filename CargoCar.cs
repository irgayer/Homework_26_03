using System;

namespace CyberForumApp
{
    class CargoCar : Car
    {
        public string Name = "Cargo car";
        public void Ride()
        {
            Go(Name, MySpeed(new Random(), 700, 1000));
        }
    }
}