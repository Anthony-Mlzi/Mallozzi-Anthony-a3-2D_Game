using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Coins
    {
        //variables
        public Vector2 coinPosition;
        public float coinRadius = 8;

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
            coinPosition = new Vector2(Random.Float(0, 800), Random.Float(0, 600));
        }
        public void renderCoins()
        {
            Draw.LineSize = 2;
            Draw.LineColor = Color.White;
            Draw.FillColor = Color.Yellow;
            Draw.Circle(coinPosition, coinRadius);
        }
    }
}
