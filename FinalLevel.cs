using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class FinalLevel
    {
        int r = 255, g = 255, b = 255;
        Vector2[] fire = new Vector2[20];
        int count = -20;
        bool isDead = false;
        public FinalLevel() { }

        public void Setup()
        {
            for (int i = 0; i < fire.Length; i++)
            {
                fire[i] = new Vector2(0, Random.Integer(0, 800));
            }
        }

        public void DoOnce(){
            count = 0;
        }

        public int GetLineX()
        {
            return count;
        }

        public void Update(Vector2 playerPosition)
        {
            Color bg = new Color(r, g, b);
            Window.ClearBackground(bg);
            r -= 2;
            g -= 2;
            b -= 2;
            if (r < -140)
            {
                for (int i = 0; i < fire.Length; i++)
                {
                    if (playerPosition.X <= fire[i].X + 45){ isDead = true; }
                    count++;
                    fire[i].X++;
                    Color orange = new Color("#f9ed04");
                    Draw.FillColor = orange;
                    Draw.Circle(fire[i], 60);
                    Color yellow = new Color("#f9b404");
                    Draw.FillColor = yellow;
                    Draw.Circle(fire[i], 45);
                    Draw.FillColor = Color.Red;
                    Draw.Circle(fire[i], 30);
                }
            }
            if (r < -100)
            {
                Color orange = new Color("#f9ed04");
                Draw.FillColor = orange;
                Draw.Circle(255, 33, 60);
            }
            if (r < -75)
            {
                Color orange = new Color("#f9b404");
                Draw.FillColor = orange;
                Draw.Circle(255, 33, 45);
            }
            if (r < -50)
            {
                Draw.FillColor = Color.Red;
                Draw.Circle(255, 33, 30);
            }
            Console.WriteLine("THERE IS NO ESCAPE YOU WILL DIE YOU WILL DIE YOU WILL DIE");

            
        }

        public bool GetIsDead(){ return isDead; }
        public void Reset(){
            r = 255;
            g = 255;
            b = 255;
            count = -20;
            isDead = false;
            for (int i = 0; i < fire.Length; i++)
            {
                fire[i] = new Vector2(0, Random.Integer(0, 800));
            }
        }

    }
}
