using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    public class AceStudent : Driver
    {
        public AceStudent(RaceCar car) : base(car)
        {
            Name = "Ace Student";
            SkillLevel = 15;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
