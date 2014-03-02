using ParticleSystem.HomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    class ParticleSystemMain
    {
        const int SimulationRows = 30;
        const int SimulationCols = 40;

        static readonly Random RandomGenerator = new Random();

        static void Main(string[] args)
        {
            var renderer = new ConsoleRenderer(SimulationRows, SimulationCols);
            //var particleOperator = new AdvancedParticleOperator();
            var particleOperator = new ExtendedParticleOperator();

            //ChickenParticle chicken = new ChickenParticle(new MatrixCoords(5, 5), new MatrixCoords(2, 2), RandomGenerator);
            //var particles = new List<Particle>(chicken.Update());
            var particles = new List<Particle>()
            {
                //new Particle(new MatrixCoords(5, 5), new MatrixCoords(1, 1)),
                new ParticleEmitter(new MatrixCoords(7, 20), new MatrixCoords(0, 0), RandomGenerator),
                //new ParticleEmitter(new MatrixCoords(5, 20), new MatrixCoords(0, 0), RandomGenerator),
                //new VariousLifetimeParticleEmitter(new MatrixCoords(29, 1), new MatrixCoords(0, 0), RandomGenerator),

                //new ParticleAttractor(new MatrixCoords(15, 8), new MatrixCoords(), 5),
                //new ParticleAttractor(new MatrixCoords(15, 20), new MatrixCoords(), 1),

                //HomeWork
                //2. TEST ChaoticParticle
                //new ChaoticParticle(new MatrixCoords(SimulationRows / 2,SimulationCols / 2), new MatrixCoords(2,2), RandomGenerator)

                //4. Test ChickenParticle
                //new ChickenParticle(new MatrixCoords(SimulationRows / 2,SimulationCols / 2), new MatrixCoords(2,2), RandomGenerator)
                //6. Test ParticleRepeller
                new ParticleRepeller(new MatrixCoords(SimulationRows / 2,SimulationCols / 2), new MatrixCoords(), 1, 3)
            };

            var engine = new Engine(renderer, particleOperator, particles, 500);

            engine.Run();
        }
    }
}
