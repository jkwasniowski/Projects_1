using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketSimulator.Components
{
    class PowerSystem : Component
    {
        float energy = 100;
        bool isPowerOn = false;

        public bool IsPowerOn => isPowerOn;
        public bool IsPowerFlowing => energy > 0 && isPowerOn;
        public float Energy => energy;

        public override Bitmap Image => IsPowerOn ? Properties.Resources.power_on : Properties.Resources.power_off;
        public override float EnergyUsage => IsPowerOn ? 0.1f : 0.0f;

        public void setEnergy(float energy)
        {
            this.energy = energy;
        }

        public override void ChangeConfiguration(float value = 0)
        {
            isPowerOn = !isPowerOn;
        }
    }
}
