using System;

namespace CyberForumApp
{
    class Bus : Car
    {
        public string Name = "Bus";
        public void Ride()
        {
            Go(Name, MySpeed(new Random(), 800, 1100));
        }
    }
}