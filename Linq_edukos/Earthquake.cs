using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_edukos
{
    class Earthquake
    {
        double depth;
        double magnitude; // Richter scale
        DateTime occurenceTime;

        public double Depth { get { return depth; } set { depth = value; } }

        public double Magnitude { get => magnitude; set => magnitude = value; }

        public DateTime OccurenceTime { get => occurenceTime; set => occurenceTime = value; }


        public Earthquake(double depth, double magnitude, DateTime occurenceTime)
        {
            this.depth = depth;
            this.Magnitude = magnitude;
            this.OccurenceTime = occurenceTime;
        }
        public Earthquake(double depth, double magnitude)
        {
            this.depth = depth;
            this.Magnitude = magnitude;
            this.OccurenceTime = DateTime.Now;
        }

        public double GetEnergy()
        {
            return (Math.Pow(10, 1.5 + magnitude + 4.8)) / (3 * Math.Pow(10, 6));
        }

        public override string ToString()
        {
            return $"Earthquake happened at : {OccurenceTime}, depth:{depth}, magnitude:{Magnitude}";
        }
    }
}
