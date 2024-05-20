using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightTask
{
    internal class TrafficLight
    {
        private Color currentColor;
        public Color Color { get=>currentColor; }
        public TrafficLight()
        {
            currentColor = Color.Red;
        }

        public void ChangeNextColor()
        {

            currentColor = (Color)(((int)currentColor + 1 )%Enum.GetNames(typeof(Color)).Length);

        }
    }
}
