using RocketSimulator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketSimulator.Commands
{
    internal class DoorCommand : IControlComponent
    {
        Door door;
        public DoorCommand(Door door)
        {
            this.door = door;
        }

        public void Execute(float value = 0)
        {
            door.ChangeConfiguration();
        }
    }
}
