using RocketSimulator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketSimulator.Commands
{
    internal class PowerSystemCommand : IControlComponent
    {
        PowerSystem system;
        public PowerSystemCommand(PowerSystem system)
        {
            this.system = system;
        }

        public void reset()
        {
            system.setEnergy(100);
        }

        public void runSimulation(float energyUsage)
        {
            var curEnergy = system.Energy;

            if (system.IsPowerOn && system.Energy > 0)
                curEnergy -= energyUsage;

            curEnergy = Math.Clamp(curEnergy, 0, 100);
            system.setEnergy(curEnergy);
        }

        public void Execute(float value = 0)
        {
            system.ChangeConfiguration();
        }
    }
}
