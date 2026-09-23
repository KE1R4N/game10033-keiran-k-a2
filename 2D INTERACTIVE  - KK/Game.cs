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
            Draw.Ellipse(200, 240, 340, 220);
            //Revisit the bow
            Draw.Triangle(350, 285, 360, 240, 390, 240);
          
            
            //cover
            Draw.SetFillColor(70, 196, 250);
            Draw.Rectangle(0, 120, 400, 120);
            //stern might be short, revisit
            Draw.SetFillColor(71, 43, 23);
            Draw.Quad(20, 210, 30, 240, 50, 210, 100, 240);

            //sea
            Draw.SetFillColor(36, 133, 131);
            Draw.Rectangle(0, 300, 400, 100);

            //fore mast
            Draw.SetFillColor(71, 43, 23);
            Draw.Rectangle(300, 70, 10, 190);

            //fore sail
            Draw.SetFillColor(250, 233, 210);
            Draw.Capsule(300, 140, 220, 140, 60);
            Draw.SetFillColor(70, 196, 250);
            Draw.Capsule(210, 140, 230, 140, 70);

            //main mast
            Draw.SetFillColor(71, 43, 23);
            Draw.Rectangle(200, 50, 10, 210);

            //main sail
            Draw.SetFillColor(250, 233, 210);
            Draw.Capsule(200, 130, 150, 130, 60);
            Draw.SetFillColor(70, 196, 250);
            Draw.Capsule(130, 130, 130, 130, 70);

            //mizzen mast
            Draw.SetFillColor(71, 43, 23);
            Draw.Rectangle(110, 70, 10, 190);

            //black flag
            Draw.SetFillColor(0, 0, 0);
            Draw.Rectangle(70, 90, 50, 30);

            //mizzen sail
            Draw.SetFillColor(250, 233, 210);
            Draw.Capsule(110, 140, 60, 140, 60);
            Draw.SetFillColor(70, 196, 250);
            Draw.Capsule(10, 140, 40, 140, 70);

           
        }
    }

}
