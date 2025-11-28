using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    internal class Cube
    {
        int firstPointX = 0;
        int firstPointY = 0;


        Vector2 pointA;
        Vector2 pointB;
        Vector2 pointC;
        Vector2 pointD;
        Vector2 pointE;
        Vector2 pointF;
        Vector2 pointG;
        int radius = 55;
        Vector2 circlePoint;
        
        bool firstTurn = true;
        bool reset = false;



        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            firstPointX = Random.Integer(1, 1000);
            firstPointY = Random.Integer(1, 750);
            pointA = new Vector2(firstPointX, firstPointY + 80);
            pointB = new Vector2(firstPointX + 80, firstPointY + 80);
            pointC = new Vector2(firstPointX, firstPointY + 160);
            pointD = new Vector2(firstPointX + 80, firstPointY + 160);
            pointE = new Vector2(firstPointX, firstPointY);
            pointF = new Vector2(firstPointX + 80, firstPointY);
            pointG = new Vector2(firstPointX + 80, firstPointY + 80);
            circlePoint = new Vector2(firstPointX + 40,firstPointY + 80 );
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update(bool collected)
        {
            Draw.LineColor = Color.Red;
            Draw.FillColor = Color.Red;

            Draw.Circle(circlePoint, 80);
            Draw.LineColor = Color.Black;
            Draw.Line(pointE, pointA); //Line 1
            Draw.Line(pointE, pointF); //Line 2
            Draw.Line(pointA, pointB); //Line 3
            Draw.Line(pointB, pointF); //Line 4
            Draw.Line(pointA, pointC); //Line 5
            Draw.Line(pointC, pointD); //Line 6
            Draw.Line(pointB, pointD); //Line 7
            Draw.Line(pointD, pointG); //Line 8
            Draw.Line(pointF, pointG); //Line 9



            if (firstTurn == true)
            {
                pointA.X--;
                pointA.Y--;

                pointB.X--;
                pointB.Y++;

                pointC.X--;
                pointC.Y--;

                pointD.X--;
                pointD.Y++;

                pointE.X++;
                pointE.Y--;

                pointF.X++;
                pointF.Y++;

                pointG.X++;
                pointG.Y++;
            }
            if (firstTurn == false)
            {
                pointA.X++;
                pointA.Y--;

                pointB.X--;
                pointB.Y--;

                pointC.X++;
                pointC.Y--;

                pointD.X--;
                pointD.Y--;

                pointE.X++;
                pointE.Y++;

                pointF.X--;
                pointF.Y++;

                pointG.X--;
                pointG.Y++;
            }


            //Changes the way it turns
            if (pointC.Y == pointG.Y) { firstTurn = false; }

            //Will reset to initial position after completing a spin
            if (pointA.X == pointD.X) { reset = true; }
            if (reset == true)
            {
                pointA = new Vector2(firstPointX, firstPointY + 80);
                pointB = new Vector2(firstPointX + 80, firstPointY + 80);
                pointC = new Vector2(firstPointX, firstPointY + 160);
                pointD = new Vector2(firstPointX + 80, firstPointY + 160);
                pointE = new Vector2(firstPointX, firstPointY);
                pointF = new Vector2(firstPointX + 80, firstPointY);
                pointG = new Vector2(firstPointX + 80, firstPointY + 80);
                reset = false;
                firstTurn = true;
            }

            if (collected == true){
                firstPointX = Random.Integer(1, 500);
                firstPointY = Random.Integer(1, 500);
                pointA = new Vector2(firstPointX, firstPointY + 80);
                pointB = new Vector2(firstPointX + 80, firstPointY + 80);
                pointC = new Vector2(firstPointX, firstPointY + 160);
                pointD = new Vector2(firstPointX + 80, firstPointY + 160);
                pointE = new Vector2(firstPointX, firstPointY);
                pointF = new Vector2(firstPointX + 80, firstPointY);
                pointG = new Vector2(firstPointX + 80, firstPointY + 80);
                circlePoint = new Vector2(firstPointX + 40, firstPointY + 80);
            }
        }


        public Vector2 getDetection()
        {
            return circlePoint;
        }
    }
}
