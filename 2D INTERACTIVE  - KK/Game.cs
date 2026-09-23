// Include the namespaces (code libraries) you need below.
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
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Raise The Black");
            Window.SetSize(400, 400);
            Draw.SetLineSize(0);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            Window.ClearBackground(70, 196, 250);

            //Hull
            Draw.SetFillColor(71, 43, 23);
            //Draw.Ellipse();
        }
    }

}
