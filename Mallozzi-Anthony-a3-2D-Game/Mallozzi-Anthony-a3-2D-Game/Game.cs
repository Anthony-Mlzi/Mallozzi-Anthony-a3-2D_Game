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

        playerController player = new playerController();

        bool matchesPickup = false;
        bool oilPickup = false;

        Vector2 crateSize = new(50, 50);
        Vector2 matchCratePosition = new(0, 115);
        Vector2 oilCratePosition = new(750, 115);
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

            ItemPickup();
            playerAttack();

            Grate();
            Matches();
            Oil();

            player.Update();
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
        public void Matches()
        {


            Draw.LineSize = 0;
            Draw.FillColor = Color.Red;
            Draw.Rectangle(matchCratePosition, crateSize);
        }
        public void Oil()
        {

            Draw.LineSize = 0;
            Draw.FillColor = Color.Blue;
            Draw.Rectangle(oilCratePosition, crateSize);
        }
        public void ItemPickup()
        {

            if (player.playerPosition.X < 50)
            {
                matchesPickup = true;
                Console.WriteLine("matches");
            }
            if (player.playerPosition.X > 750)
            {
                oilPickup= true;
                Console.WriteLine("oil");
            }
        }
        public void playerAttack()
        {
            if (oilPickup && matchesPickup)
            {
                Console.WriteLine("attack ready");
            }
        }
    }

}
