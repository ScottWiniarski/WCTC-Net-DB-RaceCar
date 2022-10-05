using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    internal class Oppressor : RaceCar
    {
        public Oppressor()
        {
            Name = "Oppressor";
            TopSpeed = 86;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} rumbles awake!");
        }
        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} kills its non-factory issue motor.");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name}'s brakes are working overtime!");
            base.Brake();
        }
    }
}
