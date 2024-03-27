using RocketSimulator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketSimulator.Commands
{
    internal class OxygenSensorCommand : IControlComponent
    {
        OxygenSensor sensor;
        public OxygenSensorCommand(OxygenSensor sensor)
        {
            this.sensor = sensor;
        }

        public void Execute(float value = 0)
        {
            sensor.ChangeConfiguration();
        }
    }
}
