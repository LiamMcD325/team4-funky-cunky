using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    internal class GameOver
    {
        Vector2[] snow = new Vector2[500];
        public GameOver() { }

        public void Setup() {
            for (int i = 0; i < snow.Length; i++)
            {
                snow[i].X = Random.Integer(0, 1100);
                snow[i].Y = Random.Integer(0, 800);
            }
        }
        /// <summary>
        ///   Update runs every frame.
        /// </summary>
        public void Update() {
            Window.ClearBackground(Color.Black);

            //Draws snow
            Draw.LineColor = Color.White;
            Draw.FillColor = Color.White;
            Draw.Rectangle(new Vector2(0, 500), new Vector2(1100, 300));

            //Draws Gravestone
            Draw.LineColor = Color.Gray;
            Draw.FillColor = Color.Gray;
            Draw.Circle(new Vector2(525, 350), 50);
            Draw.Rectangle(new Vector2(475, 350), new Vector2(100, 150));
            Text.Draw("R.I.P", new Vector2(483, 375));

            //Draws falling snowflakes
            Color outline = new Color("#CECECE");
            Draw.LineColor = outline;
            Draw.FillColor = Color.White;
            for (int i = 0; i < snow.Length; i++) {
                if((i > 200)){ snow[i].Y++; }
                if((i >  400)){ snow[i].Y++; }
                snow[i].Y++;
                if(snow[i].Y > 800) { snow[i].Y = 0; }
                Draw.Circle(snow[i], 1);
            }

            //Uncomment once incorporated restart
            Text.Draw("You can never win...", new Vector2(320, 700));

        }
    }
}
