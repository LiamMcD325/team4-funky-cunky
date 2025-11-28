using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    internal class Level2
    {
        Vector2[] holePosition = new Vector2[10];
        Vector2[] holeSize = new Vector2[10];

        bool onPit = false;
        public Level2() { }

        public void Setup(){
            for (int i = 0; i < holePosition.Length; i++) {
                holePosition[i] = new Vector2(Random.Integer(40, 1000), Random.Integer(40, 700));
            }
        }
        public void Update(Vector2 playerFeet){        
            Draw.LineColor = Color.Blue;
            Draw.FillColor = Color.Blue;
            onPit = false;
            for (int i = 0; i < holePosition.Length; i++)
            {
                Draw.Rectangle(holePosition[i], new Vector2(100,100));
                //if ((holePosition[i].X + 100) > (playerFeet.X + 100) > holePosition[i].X > playerFeet.X){ ; }
                if ((holePosition[i].X + 100) > (playerFeet.X + 100))
                {
                    if ((playerFeet.X + 100) > holePosition[i].X)
                    {
                        if (holePosition[i].X > playerFeet.X)
                        {
                            if ((holePosition[i].Y + 100) > (playerFeet.Y + 40))
                            {
                                if ((playerFeet.Y + 100) > holePosition[i].Y)
                                {
                                    if (holePosition[i].Y > playerFeet.Y)
                                    {
                                        onPit = true;
                                    }
                                    
                                }
                            }
                        }
                    }
                }
                  
                //if (playerFeet == holePosition[i]){ }         
            }

            
        }

        public bool GetDetection()
        {
            return onPit;
        }

        public void Reset()
        {
            
            onPit = false;
        }
    }
}
