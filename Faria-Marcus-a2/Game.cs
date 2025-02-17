// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using MohawkGame2D;

//rubric requirements:
// Program Input
//Program Arrays
//Program Loops
//Program Custom Drawfunction
//Code Elements

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Color DarkBlue = new Color("#04032e"); //night sky colour
        Color DarkBrown = new Color("#1e140a"); //Pirate ship colour

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
        Window.SetTitle("Pirate Ship");
        Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(DarkBlue);

            // Pirate Ship body
            Draw.FillColor = DarkBrown;
            Draw.LineColor = DarkBrown;
            Draw.Rectangle(300, 400, 200, 100);
            Draw.Square(300, 350, 50);
            Draw.Triangle(450, 400, 500, 500, 550, 400);
            Draw.Triangle(250, 350, 300, 500, 350, 350);
            Draw.Ellipse(400, 500, 200, 50);
            Draw.Rectangle(370, 240, 10, 160);
            Draw.Rectangle(470, 270, 10, 130);
            Draw.Quad(360, 240, 390, 240, 370, 260, 380, 260);
            Draw.Quad(460, 270, 490, 270, 470, 290, 480, 290);
            Draw.Rectangle(373, 220, 4, 20);
            Draw.Rectangle(473, 250, 4, 20);

            // Pirate Ship Sails and Flags
            Draw.FillColor = Color.White;
            Draw.Rectangle(340, 260, 70, 50);
            Draw.Rectangle(440, 290, 70, 50);

            //Waves
        }
    }

}
