using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_edukos
{
    class ProfessionalAthlete:Athlete
    {
        double trainingsDone;

        public ProfessionalAthlete(double trainingsDone, double scoreChance, int pointsScored, int matchesPlayed): base( scoreChance, pointsScored, matchesPlayed)
        {
            this.trainingsDone = trainingsDone;
        }

        public override int GetPoints(int numOfTries, Random random)
        {
            if (trainingsDone > 0.7) scoreChance += 0.05;
            if (trainingsDone < 0.3) scoreChance -= 0.1;

            

            if (scoreChance < 0.1) return 0;
            if (scoreChance > 1) return 1;

           return base.GetPoints(numOfTries, random);
        }


    }
}
