using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketSimulator
{
    internal abstract class Sensor : Component
    {
        public abstract override Bitmap Image { get; }

        public float minSafeValue = float.MinValue;
        public float maxSafeValue = float.MaxValue;

        // Returns 0 if safe, -1 if too low, 1 if too high
        public int isNotSafe()
        {
            var value = getValue();
            if (value < minSafeValue)
                return -1;

            if (value > maxSafeValue)
                return 1;

            return 0;
        }

        public abstract string Name { get; }
        public abstract void reset();
        public abstract void runSimulation();
        public abstract float getValue();
    }
}
