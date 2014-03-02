/*3. Create a ChickenParticle class. 
 * The ChickenParticle class moves like a ChaoticParticle, but randomly stops at different positions for several simulation ticks and, for each of those stops, creates (lays) a new ChickenParticle. 
 * You are not allowed to edit any existing class.
*/

namespace ParticleSystem.HomeWork
{
    using System;
    using System.Collections.Generic;
    
    public class ChickenParticle : ChaoticParticle
    {   
        public ChickenParticle(MatrixCoords position, MatrixCoords speed, Random rand)
            : base(position, speed, rand)
        {
            
        }

        public override IEnumerable<Particle> Update()
        {
            IEnumerable<Particle> current = base.Update();

            List<Particle> allGeneratedObjects = new List<Particle>();

            int currentGeneratedNumber = Rand.Next(10);

            if (currentGeneratedNumber % 3 == 0)
            {
                allGeneratedObjects.Add(new ChickenParticle(this.Position, new MatrixCoords(0, 0), Rand));
            }

            allGeneratedObjects.AddRange(current);

            return allGeneratedObjects;
        }
    }
}
