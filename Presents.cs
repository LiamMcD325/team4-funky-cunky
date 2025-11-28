using MohawkGame2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Presents
    {
        Texture2D textures;
        public Vector2 presentsPos = new Vector2(0, 0);
        public Vector2 presentsSize = new Vector2(50, 40);

        public void setup()
        {
            textures = Graphics.LoadTexture("MohawkGame2D\\Images\\Presents.png");
        }

        public void Update()
        {
            
            Draw.FillColor = Color.Red;
            Draw.LineColor = Color.Black;
            //1
            Draw.Rectangle(presentsPos.X + 100, presentsPos.Y + 100, presentsSize.X, presentsSize.Y);
            //2
            Draw.Rectangle(presentsPos.X + 400,presentsPos.Y + 100, presentsSize.X, presentsSize.Y);
            //3
            Draw.Rectangle(presentsPos.X + 400, presentsPos.Y + 400, presentsSize.X, presentsSize.Y);
            //4
            Draw.Rectangle(presentsPos.X + 930, presentsPos.Y + 670, presentsSize.X, presentsSize.Y);
            //5
            Draw.Rectangle(presentsPos.X + 800, presentsPos.Y + 670, presentsSize.X, presentsSize.Y);
            //6
            Draw.Rectangle(presentsPos.X + 670, presentsPos.Y + 670, presentsSize.X, presentsSize.Y);
            //7
            Draw.Rectangle(presentsPos.X + 670, presentsPos.Y, presentsSize.X, presentsSize.Y);
            //8
            Draw.Rectangle(presentsPos.X + 1030, presentsPos.Y, presentsSize.X, presentsSize.Y);
            //9
            Draw.Rectangle(presentsPos.X + 160, presentsPos.Y + 550, presentsSize.X, presentsSize.Y);
            //10
            Draw.Rectangle(presentsPos.X + 950, presentsPos.Y + 500, presentsSize.X, presentsSize.Y);

            //Graphics.Draw(textures, presentsPos.X+100, presentsPos.Y+100);
            
            

        }
    }
}
