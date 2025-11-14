using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Stars
    {
        //variables
        public Vector2 starPosition;
        public float starRadius;

        public void Setup()
        {
            initialize();
        }
        public void Update()
        {
            renderCoins();
        }
        public void initialize()
        {
            starPosition = new Vector2(Random.Float(0, 800), Random.Float(0, 600));
            starRadius = Random.Float(1, 3);
        }
        public void renderCoins()
        {
            Draw.LineSize = 0;
            Draw.LineColor = Color.White;
            Draw.FillColor = Color.Yellow;
            Draw.Circle(starPosition, starRadius);
        }
    }
}
