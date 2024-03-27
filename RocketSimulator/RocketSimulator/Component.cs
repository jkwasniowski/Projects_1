using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketSimulator
{
    abstract class Component
    {
        protected string Status { get; set; } = "";
        public abstract float EnergyUsage { get; }

        abstract public Bitmap Image { get; }
        abstract public void ChangeConfiguration(float value = 0);
    }
}
