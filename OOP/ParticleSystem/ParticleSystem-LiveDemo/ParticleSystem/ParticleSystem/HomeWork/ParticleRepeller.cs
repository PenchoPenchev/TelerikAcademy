/*5. Implement a ParticleRepeller class. A ParticleRepeller is a Particle, which pushes other particles away from it (i.e. accelerates them in a direction, opposite of the direction in which the repeller is). The repeller has an effect only on particles within a certain radius (see Euclidean distance)
*/

namespace ParticleSystem.HomeWork
{
    using System;

    public class ParticleRepeller : Particle
    {
        public int RepelPower { get; private set; }

        public int Radius { get; private set; }

        public ParticleRepeller(MatrixCoords position, MatrixCoords speed, int repelPower, int radius)
            : base(position, speed)
        {
            this.RepelPower = repelPower;
            this.Radius = radius;
        }

        public override char[,] GetImage()
        {
            return new char[,] { { 'R' } };
        }
    }
}
