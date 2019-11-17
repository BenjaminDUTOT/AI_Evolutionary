using System;
using System.Collections.Generic;
using System.Text;

namespace AI_Evolutionary
{
    public class Point
    {
        public float x { get; set; }
        public float y { get; set; }

        public Point(float X, float Y)
        {
            this.x = X;
            this.y = Y;
        }
    }
}
