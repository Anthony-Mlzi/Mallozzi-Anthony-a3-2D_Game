// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
using System.Net.Http.Headers;
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
        PlayerController player = new PlayerController();
        Coins[] coin = new Coins[20];

        ColorF backgroundColor = new(0.7f, 0.9f, 1);

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            //game image settings
            Window.SetSize(800, 600);
            Window.SetTitle("2D Game");

            //place classes
            for (int i = 0; i < coin.Length; i++)
            {
                coin[i] = new Coins();
                coin[i].Setup();
            }
        }
        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(backgroundColor);

            for (int i = 0; i < coin.Length; i++)
            {
                coin[i].Update();
            }
            player.Update();

        }

    }

}
