/*5. Implement a ParticleRepeller class. A ParticleRepeller is a Particle, which pushes other particles away from it (i.e. accelerates them in a direction, opposite of the direction in which the repeller is). The repeller has an effect only on particles within a certain radius (see Euclidean distance)
*/

namespace ParticleSystem.HomeWork
{
    using System;
    using System.Collections.Generic;
    using ParticleSystem;

    public class ExtendedParticleOperator : ParticleUpdater
    {
        private List<Particle> currentTickParticles = new List<Particle>();
        private List<ParticleRepeller> currentTickRepellers = new List<ParticleRepeller>();

        public override IEnumerable<Particle> OperateOn(Particle p)
        {
            var potentialRepeller = p as ParticleRepeller;
            if (potentialRepeller != null)
            {
                currentTickRepellers.Add(potentialRepeller);
            }
            else
            {
                this.currentTickParticles.Add(p);
            }

            return base.OperateOn(p);
        }

        public override void TickEnded()
        {
            foreach (var repeller in this.currentTickRepellers)
            {
                foreach (var particle in this.currentTickParticles)
                {
                    int radius = (int)Math.Sqrt((repeller.Position.Col - particle.Position.Col) *
                        (repeller.Position.Col - particle.Position.Col) +
                        (repeller.Position.Row - particle.Position.Row) *
                        (repeller.Position.Row - particle.Position.Row));

                    if (radius < repeller.Radius)
                    {
                        var currParticleToAttractorVector = repeller.Position - particle.Position;

                        int pToRepRow = currParticleToAttractorVector.Row;
                        pToRepRow = DecreaseVectorCoordToPower(repeller, pToRepRow);

                        int pToRepCol = currParticleToAttractorVector.Col;
                        pToRepCol = DecreaseVectorCoordToPower(repeller, pToRepCol);

                        //the only difference between attractor and repeller
                        var currAcceleration = new MatrixCoords(-pToRepRow, -pToRepCol);

                        particle.Accelerate(currAcceleration);
                    }
                }
            }

            this.currentTickParticles.Clear();
            this.currentTickRepellers.Clear();

            base.TickEnded();
        }

        private static int DecreaseVectorCoordToPower(ParticleRepeller repeller, int pToAttrCoord)
        {
            if (Math.Abs(pToAttrCoord) > repeller.RepelPower)
            {
                pToAttrCoord = (pToAttrCoord / (int)Math.Abs(pToAttrCoord)) * repeller.RepelPower;
            }
            return pToAttrCoord;
        }
    }
}
