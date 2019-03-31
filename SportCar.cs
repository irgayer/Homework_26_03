using System;

namespace CyberForumApp
{
    class SportCar : Car
    {
        public string Name = "Sport car";

        public void Ride()
        {
            Go(Name, MySpeed(new Random(), 500, 800));
        }
    }
}