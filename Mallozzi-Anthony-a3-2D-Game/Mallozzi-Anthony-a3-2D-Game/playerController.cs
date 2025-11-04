using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class PlayerController
    {
        //class variables

        public Vector2 playerPosition = new(400, 0);
        public Vector2 playerSize = new(50, 50);
        public Vector2 velocity = new(0, 0);
        public Vector2 gravity = new(0, 500);

        public float bottomEdge;
        public float topEdge;
        public float leftEdge;
        public float rightEdge;

        public void setup()
        {

        }
        public void update()
        {

            //player gravity
            velocity += gravity * Time.DeltaTime;
            playerPosition += velocity * Time.DeltaTime;

            //player collision
            bottomEdge = playerPosition.Y + 50;
            topEdge = playerPosition.Y;

            if (bottomEdge >= 600)
            {
                velocity *= -1;
            }

            //player draw
            Draw.FillColor = Color.Red;
            Draw.Rectangle(playerPosition, playerSize);

            
        }
    }
}
