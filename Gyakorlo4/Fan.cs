using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo4
{
     class Fan
    {
        public const int SLOW = 1, MEDIUM = 2, FAST = 3;
        private int speed;
        private Boolean on;
        private double radius;
        string color;

        public Fan()
        {
            this.speed = SLOW;
            this.on = false;
            this.radius = 5;
            this.color = "blue";
        }

        public int Speed { get { return speed; } set { speed = value; } }
        public Boolean On { get { return on; } set { on = value; } }
        public double Radius { get { return radius; } set { radius = value; } }
        public string Color { get { return color; } set { color = value; } }

        public override string ToString()
        {
            if(On == false)
            {
                return $"{Speed} speed - {Color} color - {Radius} radius";
            }
            return $"{Color} color - {Radius} radius - fan is off";
        }

    }
}
