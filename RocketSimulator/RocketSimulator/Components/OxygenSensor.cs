using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketSimulator.Components
{
    internal class OxygenSensor : Sensor
    {
        float oxygenLevel = 0;
        bool isValveOpen = false;

        public bool IsValveOpen => isValveOpen;
        public float OxygenLevelRaw => oxygenLevel;
        public override Bitmap Image => IsValveOpen ? Properties.Resources.o2_on : Properties.Resources.o2_off;
        public override float EnergyUsage => IsValveOpen ? 0.3f : 0.0f;

        public override string Name => "Oxygen";

        private Door door;
        public OxygenSensor(Door door)
        {
            minSafeValue = 0.1f;
            this.door = door;

            reset();
        }

        public override void reset()
        {
            oxygenLevel = 100f;
        }

        public void setOxygen(float oxygen)
        {
            this.oxygenLevel = oxygen;
        }

        public float getOxygen() => oxygenLevel;

        public override void ChangeConfiguration(float value = 0)
        {
            isValveOpen = !isValveOpen;
        }

        public override float getValue() => getOxygen();

        public override void runSimulation()
        {
            var value = OxygenLevelRaw;
            if (!IsValveOpen)
            {
                value -= door.IsOpen ? 6 : 3;
            }
            else
            {
                value += 4;
            }
            value = Math.Clamp(value, 0, 100);
            setOxygen(value);
        }
    }
}
