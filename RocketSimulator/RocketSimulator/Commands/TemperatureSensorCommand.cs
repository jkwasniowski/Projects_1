using RocketSimulator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketSimulator.Commands
{
    internal class TemperatureSensorCommand : IControlComponent
    {
        TemperatureSensor sensor;
        public TemperatureSensorCommand(TemperatureSensor sensor)
        {
            this.sensor = sensor;
        }

        public void Execute(float value = 0)
        {
            sensor.ChangeConfiguration();
        }
    }
}
