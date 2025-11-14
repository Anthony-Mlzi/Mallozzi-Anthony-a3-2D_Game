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
        Stars[] star = new Stars[20];
        LampController lamp = new LampController();

        bool gamestart = false;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            //game image settings
            Window.SetSize(800, 600);
            Window.SetTitle("2D Game");

            //generate random stars
            for (int i = 0; i < star.Length; i++)
            {
                star[i] = new Stars();
                star[i].Setup();
            }

            lamp.Setup();

            player.Setup();
        }
        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Black);

            if (!gamestart)
            {
                Text.Color = Color.Yellow;
                Text.Draw("Lamplight", 300, 300);
                Text.Draw("press ENTER to play", 225, 350);
                if (Input.IsKeyboardKeyPressed(KeyboardInput.Enter))
                {
                    gamestart = true;
                }
            }
            if (gamestart)
            {
                //gets star update
                for (int i = 0; i < star.Length; i++)
                {
                    star[i].Update();
                }

                //place player controller
                player.Update(lamp);

                lamp.Update();            
            }
        }
    }

}
