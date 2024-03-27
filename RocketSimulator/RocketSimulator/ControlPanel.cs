using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketSimulator
{
    internal class ControlPanel
    {
        private List<IControlComponent> queuedActions = new List<IControlComponent>();

        public void AddCommand(IControlComponent component)
        {
            queuedActions.Add(component);
        }

        public void RemoveCommand(IControlComponent component)
        {
            queuedActions.Remove(component);
        }

        public void Execute()
        {
            foreach (IControlComponent component in queuedActions)
            {
                component.Execute();
            }

            queuedActions.Clear();
        }
    }
}
