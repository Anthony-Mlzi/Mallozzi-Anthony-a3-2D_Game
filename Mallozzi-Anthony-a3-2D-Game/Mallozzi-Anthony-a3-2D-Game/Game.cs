// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        Vector2 playerPosition = new(400, 130);
        Vector2 playerSize = new(15, 25);

        Vector2 gravity = new(0, 500);
        Vector2 velocity = new(0, 0);
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("2D Game");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.DarkGray);

            Grate();
            Player();

        }
        public void Gravity()
        {

        }
        public void Player()
        {
            float moveSpeed = 10;

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
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                playerPosition.X += moveSpeed;
                Console.WriteLine("right");
                if (playerPosition.X > 785)
                {
                    playerPosition.X = 785;
                }
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                Console.WriteLine("jump");

                velocity += gravity * Time.DeltaTime;
                playerPosition -= velocity * Time.DeltaTime;
            }

        }
        public void Grate()
        {

            for (int i = 0; i < 41; i++)
            {
                Vector2 gratePosition = new Vector2(0, 100);
                Vector2 grateSize = new Vector2(10, 75);

                gratePosition.X += i * 20 + 5;

                Draw.LineColor = Color.Black;
                Draw.LineSize = 2;
                Draw.FillColor = Color.Black;
                Draw.Rectangle(gratePosition, grateSize);
            }
        }
    }

}
