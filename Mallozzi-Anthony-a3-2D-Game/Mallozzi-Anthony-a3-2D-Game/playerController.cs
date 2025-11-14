using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class PlayerController
    {
        //class variables

        public Vector2 playerPosition = new(400, 300);
        public Vector2 playerSize = new(20, 20);
        public Vector2 velocity = new(0, 0);
        public Vector2 gravity = new(0, 500);

        public float lampLight = 40;
        public float lampCollision = 30;

        public float bottomEdge;
        public float topEdge;
        public float leftEdge;
        public float rightEdge;

        float jumpHeight = 250;

        public bool lampOn = false;
        public void Setup()
        {
        }
        public void Update(LampController lamp)
        {
            PlayerInput();

            ProcessGravity();

            ProcessCollision();

            LampCollision(lamp);

            DrawPlayer();
        }
        public void ProcessGravity()
        {
            //basic gravity equation
            velocity += gravity * Time.DeltaTime;
            playerPosition += velocity * Time.DeltaTime;
        }
        public void ProcessCollision()
        {
            //defining player collision
            bottomEdge = playerPosition.Y + playerSize.Y;
            topEdge = playerPosition.Y;
            leftEdge = playerPosition.X;
            rightEdge = playerPosition.X + playerSize.X;

            if (bottomEdge > Window.Height)
            {
                playerPosition.Y = Window.Height - playerSize.Y;
            }
            if (topEdge < 0)
            {
                playerPosition.Y = 0;
            }
            if (leftEdge < 0)
            {
                playerPosition.X = 0;
            }
            if (rightEdge > Window.Width)
            {
                playerPosition.X = Window.Width - playerSize.X;
            }

        }
        public void PlayerInput()
        {
            //move right
            if (Input.IsKeyboardKeyDown(KeyboardInput.Right)) playerPosition.X += 2;

            //move left
            if (Input.IsKeyboardKeyDown(KeyboardInput.Left)) playerPosition.X -= 2;

            //jump
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Up))
            {
                velocity.Y = jumpHeight;
                velocity *= -1;
            }  
        }
        public void DrawPlayer()
        {
            //player
            Draw.FillColor = Color.Black;
            Draw.Rectangle(playerPosition, playerSize);
        }
        public void LampCollision(LampController lamp)
        {


            Draw.FillColor = Color.Yellow;
            Draw.LineSize = 0;
            Draw.Circle(playerPosition.X + 10, playerPosition.Y + 10, lampLight);

            Draw.FillColor = Color.White;
            Draw.LineSize = 0;
            Draw.Circle(playerPosition.X + 10, playerPosition.Y + 10, lampCollision);

            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                lampLight = 80;
                if (Vector2.Distance(lamp.lampPosition, playerPosition) < 30)
                {
                    Console.WriteLine("YAYAYYAYA");

                    lampOn = true;
                }
            }
            else
            {
                lampLight = 40;
            }

            if (lampOn == true)
            {
                Draw.FillColor = Color.Yellow;
                Draw.LineSize = 0;
                Draw.Circle(lamp.lampPosition, 80);

                
            }

        }
    }
}