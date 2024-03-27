using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketSimulator.Components
{
    class DistanceSensor : Sensor
    {
        public override Bitmap Image => new Bitmap(0, 0);
        public override string Name => "Speed";
        public override float EnergyUsage => 0f;

        public float Speed = 0f;
        public float Distance = 0f;

        private Engine engine;
        private ProgressBar bar;
        private Label speedLabel;

        public DistanceSensor(Engine engine, ProgressBar missionCompletionProgressBar, Label speedLabel)
        {
            this.engine = engine;
            this.bar = missionCompletionProgressBar;
            this.speedLabel = speedLabel;
            
            reset();
        }

        public override void ChangeConfiguration(float value = 0) { }

        public override float getValue() => Distance;

        public override void reset()
        {
            Speed = 0f;
            Distance = 0f;
        }

        public override void runSimulation()
        {
            Speed += engine.Power * (Random.Shared.Next(900, 1100) / 1000f);
            Distance += Speed;

            Distance = Math.Clamp(Distance, bar.Minimum, bar.Maximum);
            speedLabel.Text = $"{(int)(Speed * Random.Shared.Next(29, 34))} m/s";
        }
    }
}
