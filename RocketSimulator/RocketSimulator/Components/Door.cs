using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketSimulator.Components
{
    internal class Door : Component
    {
        string cabine = "";
        bool isOpen = true;
        public bool IsOpen => isOpen;

        public override Bitmap Image => IsOpen ? Properties.Resources.door_open : Properties.Resources.door_closed;
        public override float EnergyUsage => IsOpen ? 0.0f : 1f;

        public Door(string cabine)
        {
            this.cabine = cabine;
        }

        public override void ChangeConfiguration(float value = 0)
        {
            isOpen = !isOpen;
        }
    }
}
