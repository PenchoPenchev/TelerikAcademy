/*1. Create a ChaoticParticle class, which is a Particle, randomly changing its movement (Speed). You are not allowed to edit any existing class.
*/

namespace ParticleSystem.HomeWork
{
    using System;

    public class ChaoticParticle : Particle
    {
        private const int lowerBound = -3;
        private const int upperBound = 3;
        
        public Random Rand { get; private set; }

        public ChaoticParticle(MatrixCoords position, MatrixCoords speed, Random rand)
            : base(position, speed)
        {
            this.Rand = rand;
        }

        protected override void Move()
        {
            this.Speed = new MatrixCoords(this.Rand.Next(lowerBound, upperBound), this.Rand.Next(lowerBound, upperBound));
            this.Position += this.Speed;
        }
    }
}
