using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class LampController
    {
        //place variables
        public Vector2 lampPosition = new Vector2();
        public float lampRadius = 5;

        public void Setup()
        {
            lampPosition = new(Random.Float(50, 750), Random.Float(50, 550));
        }
        public void Update()
        {
            drawLamp();
        }

        public void drawLamp()
        {
            Draw.LineSize = 0;
            Draw.FillColor = Color.Black;
            Draw.Circle(lampPosition, lampRadius);
        }
    }
}
