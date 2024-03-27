using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketSimulator
{
    internal interface IControlComponent
    {
        public void Execute(float value = 0);
    }
}
