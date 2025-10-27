using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class playerController
    {

        public Vector2 playerPosition = new(400, 130);
        public Vector2 playerSize = new(15, 25);

        public Vector2 gravity = new(0, 500);
        public Vector2 velocity = new(0, 0);

        public float moveSpeed = 3;
        public float jumpHeight = 300;

        public bool jump = false;

        public void setup()
        {

        }
        public void Update()
        {
            Player();
            Gravity();
        }
        public void Gravity()
        {
            velocity += gravity * Time.DeltaTime;
            playerPosition += velocity * Time.DeltaTime;

            if (playerPosition.Y >= 130)
            {
                playerPosition.Y = 130;
            }
        }

        public void Player()
        {

            Draw.LineSize = 2;
            Draw.FillColor = Color.White;
            Draw.Rectangle(playerPosition, playerSize);

            if (Input.IsKeyboardKeyDown(KeyboardInput.Left))
            {
                playerPosition.X -= moveSpeed;
                Console.WriteLine("left");
                if (playerPosition.X < 0)
                {
                    playerPosition.X = 0;
                }
                if (Input.IsKeyboardKeyPressed(KeyboardInput.Up) && playerPosition.Y == 130)
                {
                    velocity.Y = jumpHeight;
                    Console.WriteLine("jump");
                    velocity *= -1;
                }
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                playerPosition.X += moveSpeed;
                Console.WriteLine("right");
                if (playerPosition.X > 785)
                {
                    playerPosition.X = 785;
                }
                if (Input.IsKeyboardKeyPressed(KeyboardInput.Up) && playerPosition.Y == 130)
                {
                    velocity.Y = jumpHeight;
                    Console.WriteLine("jump");
                    velocity *= -1;
                }
            }
            else if (Input.IsKeyboardKeyPressed(KeyboardInput.Up) && playerPosition.Y == 130)
            {
                velocity.Y = jumpHeight;
                Console.WriteLine("jump");
                velocity *= -1;
            }

        }
    }
}
