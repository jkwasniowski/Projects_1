using RocketSimulator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketSimulator.Commands
{
    internal class EngineCommand : IControlComponent
    {
        Engine engine;
        public EngineCommand(Engine engine)
        {
            this.engine = engine;
        }

        public void Execute(float value = 0)
        {
            engine.ChangeConfiguration(value);
        }
    }
}
