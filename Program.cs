using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CyberForumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SportCar car = new SportCar();
            Bus bus = new Bus();
            CargoCar cargoCar = new CargoCar();
            Automobile automobile = new Automobile();

            List<Thread> threads = new List<Thread>()
            {
                new Thread(cargoCar.Ride),
                new Thread(car.Ride),
                new Thread(bus.Ride),
                new Thread(automobile.Ride)
            };
            foreach (Thread list in threads)
            {
                list.Start();
            }
        }
    }
}