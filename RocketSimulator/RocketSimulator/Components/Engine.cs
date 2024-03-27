using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketSimulator.Components
{
    class Engine : Component
    {
        private float power = 0;
        public float Power { get => power; }

        private Bitmap _image = Properties.Resources.engine_off;
        public override Bitmap Image => _image;

        public override float EnergyUsage => Power * 2f;

        public override void ChangeConfiguration(float value = 0)
        {
            power = value;

            _image = (Bitmap)Properties.Resources.engine_on.Clone();
                
            for(var w = 0; w < _image.Width; w++)
            {
                for(var h = 0; h < _image.Height; h++)
                {
                    Color c = _image.GetPixel(w, h);
                    if (c.R < 240 || c.B > 0)
                        continue;

                    Color newColor = Color.FromArgb((int)(c.R * Power), (int)(c.G * Power), c.B);
                    _image.SetPixel(w, h, newColor);
                }
            }
            
        }
    }
}
