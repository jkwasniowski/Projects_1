using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketSimulator.Components
{
    internal class TemperatureSensor : Sensor
    {
        float temperatureLevel = 0f;
        bool isHeaterOn = false;

        public bool IsHeaterOn => isHeaterOn;
        public override Bitmap Image => IsHeaterOn ? Properties.Resources.heater_on : Properties.Resources.heater_off;
        public override float EnergyUsage => IsHeaterOn ? 1f : 0.0f;

        public override string Name => "Temperature";

        private Door door;
        public TemperatureSensor(Door door)
        {
            minSafeValue = 0.1f;
            maxSafeValue = 99.9f;

            this.door = door;
            reset();
        }

        public override void reset()
        {
            temperatureLevel = 80f;
        }

        public void setTemperature(float temp)
        {
            temperatureLevel = temp;
        }

        public float getTemperature() => temperatureLevel;

        public override void ChangeConfiguration(float value = 0)
        {
            isHeaterOn = !isHeaterOn;
        }

        public override float getValue() => getTemperature();

        public override void runSimulation()
        {
            var value = temperatureLevel;

            var highValue = 3;
            var lowValue = 1;
            if (IsHeaterOn)
            {
                value += highValue;
            }
            else
            {
                value -= door.IsOpen ? highValue : lowValue;
            }
            value = Math.Clamp(value, 0, 100);
            setTemperature(value);
        }
    }
}
