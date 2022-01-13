using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_edukos
{
    class Athlete
    {
        protected double scoreChance;
        protected int pointsScored;
        protected int matchesPlayed;

        public Athlete(double scoreChance, int pointsScored, int matchesPlayed)
        {
            this.pointsScored = pointsScored;
            this.matchesPlayed = matchesPlayed;

            if (scoreChance < 0.1)
            {
                this.scoreChance = 0.1;
            }
            if (scoreChance > 0.9)
            {
                this.scoreChance = 0.9;
            }
            if(scoreChance>=0.1 && scoreChance <= 0.9)
            {
                this.scoreChance=scoreChance;
            }

            
        }

        public virtual int GetPoints(int numOfTries, Random random)
        {
            int counter = 0;
            
            
            for(int i=0; i<numOfTries; i++)
            {
                if (random.NextDouble() < scoreChance)
                    counter++;
            }
           
            return counter;

        }







    }
}
