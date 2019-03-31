using System;

namespace CyberForumApp
{
    class Automobile : Car
    {
        public string Name = "Automobile";

        public void Ride()
        {
            Go(Name, MySpeed(new Random(), 600, 900));
        }
    }
}