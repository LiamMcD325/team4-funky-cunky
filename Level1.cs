//using GAME_10003_Game_Development_Foundations___2D_Game_Template__v1._4_1.MohawkGame2D;
using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Level1
    {
        public Vector2 badRectSize = new Vector2(100, 200);
        public Vector2 badRectPos = new Vector2(0, 600);
        Vector2 exitSize = new Vector2(100, 100);
        Vector2 exitPos = new Vector2(800, 350);
        Texture2D textureYay;
        Presents presentsYay = new Presents();
        bool onPit = false;
        Assets bg = new Assets();

        bool present1Collected = false;
        bool present2Collected = false;
        bool present3Collected = false;
        bool present4Collected = false;
        bool present5Collected = false;
        bool present6Collected = false;
        bool present7Collected = false;
        bool present8Collected = false;
        bool present9Collected = false;
        bool present10Collected = false;

        // integer that helps game.cs determine whether or not the scene can change.
        public int theExit = 0;


        public void Setup()
        {
            textureYay = Graphics.LoadTexture("MohawkGame2D\\Images\\Lava.png");
           
        } 

        public void Update(Vector2 feetPosition)
        {
            Window.ClearBackground(Color.White);
            bg.Update("MohawkGame2D\\Images\\Level1Floor.png");
            //the obstacles
            Draw.LineColor = Color.Yellow;
            Draw.FillColor = Color.Yellow;
            
            Draw.Rectangle(badRectPos.X + 500, badRectPos.Y - 550, badRectSize.X+200, badRectSize.Y);
            Draw.Rectangle(badRectPos.X, badRectPos.Y, badRectSize.X-50, badRectSize.Y);
            Draw.Rectangle(badRectPos.X, badRectPos.Y-150, badRectSize.X-50, badRectSize.Y);           
            Draw.Rectangle(badRectPos.X+180, badRectPos.Y + 140, badRectSize.X + 1000, badRectSize.Y-130);             
            Draw.Rectangle(badRectPos.X + 250, badRectPos.Y - 30, badRectSize.X + 300, badRectSize.Y - 130);
            Draw.Rectangle(badRectPos.X + 770, badRectPos.Y - 30, badRectSize.X + 300, badRectSize.Y - 130);
            Draw.Rectangle(badRectPos.X + 900, badRectPos.Y - 650, badRectSize.X, badRectSize.Y+40);
            Draw.Rectangle(badRectPos.X, badRectPos.Y-600, badRectSize.X - 50, badRectSize.Y);
            Draw.Rectangle(badRectPos.X, badRectPos.Y-600, badRectSize.X + 150, badRectSize.Y-150);
            Draw.Rectangle(badRectPos.X+200, badRectPos.Y - 600, badRectSize.X, badRectSize.Y + 150);

            Graphics.Draw(textureYay, badRectPos.X, badRectPos.Y);
           

            //draw the presents!!
            presentsYay.Update();

            //compute collision boundaries for player 
            float playerEdge = feetPosition.X;
            float playerRightEdge = feetPosition.X + 100;
            float playerTop = feetPosition.Y;
            float playerBottom = feetPosition.Y + 60;


            //compute collision boundaries for obstacle 1
            float leftEdge1 = badRectPos.X + 500;
            float rightEdge1 = (badRectPos.X + 500) + (badRectSize.X + 200);
            float topEdge1 = (badRectPos.Y - 650);
            float bottomEdge1 = (badRectPos.Y - 650) + badRectSize.Y - 30;
           
           
            //check if things are colliding
            bool doesOverlapLeft = leftEdge1 < playerRightEdge;
            bool doesOverlapRight = rightEdge1 > playerEdge;
            bool doesOverlapTop = topEdge1 < playerBottom;
            bool doesOverlapBottom = bottomEdge1 > playerTop;

            bool doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                
                onPit = true;
            }

            //compute collision for obstacle 2
            leftEdge1 = badRectPos.X;
            rightEdge1 = (badRectPos.X) + (badRectSize.X - 50);
            topEdge1 = (badRectPos.Y - 150);
            bottomEdge1 = (badRectPos.Y) + badRectSize.Y;

            doesOverlapLeft = leftEdge1 < playerRightEdge;
            doesOverlapRight = rightEdge1 > playerEdge;
            doesOverlapTop = topEdge1 < playerBottom;
            doesOverlapBottom = bottomEdge1 > playerTop;

            doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
               
                onPit = true;
            }

            //compute collision for obstacle 3
            leftEdge1 = badRectPos.X;
            rightEdge1 = (badRectPos.X) + (badRectSize.X - 50);
            topEdge1 = (badRectPos.Y - 220);
            bottomEdge1 = (badRectPos.Y - 220) + badRectSize.Y;

            doesOverlapLeft = leftEdge1 < playerRightEdge;
            doesOverlapRight = rightEdge1 > playerEdge;
            doesOverlapTop = topEdge1 < playerBottom;
            doesOverlapBottom = bottomEdge1 > playerTop;

            doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                
                onPit = true;
            }

            //compute collision for obstacle 4           
            leftEdge1 = badRectPos.X + 180;
            rightEdge1 = (badRectPos.X + 180) + (badRectSize.X + 1000);
            topEdge1 = (badRectPos.Y+50);
            bottomEdge1 = (badRectPos.Y+50) + badRectSize.Y - 130;

            doesOverlapLeft = leftEdge1 < playerRightEdge;
            doesOverlapRight = rightEdge1 > playerEdge;
            doesOverlapTop = topEdge1 < playerBottom;
            doesOverlapBottom = bottomEdge1 > playerTop;

            doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                
                onPit = true;
            }

            //compute collision for obstacle 5
            leftEdge1 = badRectPos.X + 250;
            rightEdge1 = (badRectPos.X + 250) + (badRectSize.X + 290);
            topEdge1 = (badRectPos.Y - 130);
            bottomEdge1 = (badRectPos.Y - 130) + badRectSize.Y - 150;


            doesOverlapLeft = leftEdge1 < playerRightEdge;
            doesOverlapRight = rightEdge1 > playerEdge;
            doesOverlapTop = topEdge1 < playerBottom;
            doesOverlapBottom = bottomEdge1 > playerTop;

            doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                onPit = true;
            }

            //compute collision for obstacle 6          
            leftEdge1 = badRectPos.X + 770;
            rightEdge1 = (badRectPos.X + 770) + (badRectSize.X + 300);
            topEdge1 = (badRectPos.Y - 130);
            bottomEdge1 = (badRectPos.Y - 130) + badRectSize.Y - 160;

            doesOverlapLeft = leftEdge1 < playerRightEdge;
            doesOverlapRight = rightEdge1 > playerEdge;
            doesOverlapTop = topEdge1 < playerBottom;
            doesOverlapBottom = bottomEdge1 > playerTop;

            doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                
                onPit = true;
            }

            
            //compute collision for obstacle 7
            leftEdge1 = badRectPos.X + 900;
            rightEdge1 = (badRectPos.X + 900) + (badRectSize.X + 15);
            topEdge1 = (badRectPos.Y - 730);
            bottomEdge1 = (badRectPos.Y - 730) + badRectSize.Y;

            doesOverlapLeft = leftEdge1 < playerRightEdge;
            doesOverlapRight = rightEdge1 > playerEdge;
            doesOverlapTop = topEdge1 < playerBottom;
            doesOverlapBottom = bottomEdge1 > playerTop;

            doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                
                onPit = true;
            }

            //compute collision for obstacle 8
            leftEdge1 = badRectPos.X;
            rightEdge1 = (badRectPos.X) + (badRectSize.X - 50);
            topEdge1 = (badRectPos.Y - 715);
            bottomEdge1 = (badRectPos.Y - 715) + badRectSize.Y;

            doesOverlapLeft = leftEdge1 < playerRightEdge;
            doesOverlapRight = rightEdge1 > playerEdge;
            doesOverlapTop = topEdge1 < playerBottom;
            doesOverlapBottom = bottomEdge1 > playerTop;

            doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                
                onPit = true;
            }

                //compute collision for obstacle 9               
                leftEdge1 = badRectPos.X;
                rightEdge1 = (badRectPos.X) + (badRectSize.X + 150);
                topEdge1 = (badRectPos.Y - 700);
                bottomEdge1 = (badRectPos.Y - 700) + badRectSize.Y - 150;

                doesOverlapLeft = leftEdge1 < playerRightEdge;
                doesOverlapRight = rightEdge1 > playerEdge;
                doesOverlapTop = topEdge1 < playerBottom;
                doesOverlapBottom = bottomEdge1 > playerTop;

                doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
                if (doesOverlap)
                {
                    
                    onPit = true;
                }
            
            //compute collision for obstacle 10        
            leftEdge1 = badRectPos.X + 200;
            rightEdge1 = (badRectPos.X + 200) + (badRectSize.X);
            topEdge1 = (badRectPos.Y - 700);
            bottomEdge1 = (badRectPos.Y - 700) + badRectSize.Y + 150;

            doesOverlapLeft = leftEdge1 < playerRightEdge;
            doesOverlapRight = rightEdge1 > playerEdge;
            doesOverlapTop = topEdge1 < playerBottom;
            doesOverlapBottom = bottomEdge1 > playerTop;

            doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;
            if (doesOverlap)
            {
                
                onPit = true;
            }


            // presents collision
            
            //present #1
            float presentsEdge = presentsYay.presentsPos.X + 100;
            float presentsRightEdge = (presentsYay.presentsPos.X + 100) + (presentsYay.presentsSize.X);
            float presentsTopEdge = (presentsYay.presentsPos.Y);
            float presentsBottomEdge = (presentsYay.presentsPos.Y) + presentsYay.presentsSize.Y;

            bool presentOverlapLeft = presentsEdge < playerRightEdge;
            bool presentOverlapRight = presentsRightEdge > playerEdge;
            bool presentOverlapTop = presentsTopEdge < playerBottom;
            bool presentOverlapBottom = presentsBottomEdge > playerTop;

            bool doesPresentOverlap = presentOverlapLeft && presentOverlapRight && presentOverlapTop && presentOverlapBottom;
            if (doesPresentOverlap)               
            {                                       
                Draw.FillColor = Color.Green;
                Draw.Rectangle(presentsYay.presentsPos.X + 100, presentsYay.presentsPos.Y + 100, presentsYay.presentsSize.X, presentsYay.presentsSize.Y);
                present1Collected = true;                                                                       
            }
           

            //present #2          
            presentsEdge = presentsYay.presentsPos.X + 400;
            presentsRightEdge = (presentsYay.presentsPos.X + 400) + (presentsYay.presentsSize.X);
            presentsTopEdge = (presentsYay.presentsPos.Y);
            presentsBottomEdge = (presentsYay.presentsPos.Y) + presentsYay.presentsSize.Y;

            presentOverlapLeft = presentsEdge < playerRightEdge;
            presentOverlapRight = presentsRightEdge > playerEdge;
            presentOverlapTop = presentsTopEdge < playerBottom;
            presentOverlapBottom = presentsBottomEdge > playerTop;

            doesPresentOverlap = presentOverlapLeft && presentOverlapRight && presentOverlapTop && presentOverlapBottom;
            if (doesPresentOverlap)
            {                               
                Draw.LineColor = Color.Green;
                Draw.FillColor = Color.Green;
                Draw.Rectangle(presentsYay.presentsPos.X + 400, presentsYay.presentsPos.Y + 100, presentsYay.presentsSize.X, presentsYay.presentsSize.Y);
                present2Collected = true;            

            }
           

            //present #3
            presentsEdge = presentsYay.presentsPos.X + 400;
            presentsRightEdge = (presentsYay.presentsPos.X + 400) + (presentsYay.presentsSize.X);
            presentsTopEdge = (presentsYay.presentsPos.Y + 310);
            presentsBottomEdge = (presentsYay.presentsPos.Y + 310) + presentsYay.presentsSize.Y - 35;

            presentOverlapLeft = presentsEdge < playerRightEdge;
            presentOverlapRight = presentsRightEdge > playerEdge;
            presentOverlapTop = presentsTopEdge < playerBottom;
            presentOverlapBottom = presentsBottomEdge > playerTop;

            doesPresentOverlap = presentOverlapLeft && presentOverlapRight && presentOverlapTop && presentOverlapBottom;
            if (doesPresentOverlap)
            {
                Draw.LineColor = Color.Green;
                Draw.FillColor = Color.Green;
                Draw.Rectangle(presentsYay.presentsPos.X + 400, presentsYay.presentsPos.Y + 400, presentsYay.presentsSize.X, presentsYay.presentsSize.Y);
                present3Collected = true;

            }

            //present #4          
            presentsEdge = presentsYay.presentsPos.X + 930;
            presentsRightEdge = (presentsYay.presentsPos.X + 930) + (presentsYay.presentsSize.X);
            presentsTopEdge = (presentsYay.presentsPos.Y + 600);
            presentsBottomEdge = (presentsYay.presentsPos.Y + 600) + presentsYay.presentsSize.Y - 35;

            presentOverlapLeft = presentsEdge < playerRightEdge;
            presentOverlapRight = presentsRightEdge > playerEdge;
            presentOverlapTop = presentsTopEdge < playerBottom;
            presentOverlapBottom = presentsBottomEdge > playerTop;

            doesPresentOverlap = presentOverlapLeft && presentOverlapRight && presentOverlapTop && presentOverlapBottom;
            if (doesPresentOverlap)
            {
                Draw.LineColor = Color.Green;
                Draw.FillColor = Color.Green;
                Draw.Rectangle(presentsYay.presentsPos.X + 930, presentsYay.presentsPos.Y + 670, presentsYay.presentsSize.X, presentsYay.presentsSize.Y);
                present4Collected = true;
            }

            //present #5           
            presentsEdge = presentsYay.presentsPos.X + 800;
            presentsRightEdge = (presentsYay.presentsPos.X + 800) + (presentsYay.presentsSize.X);
            presentsTopEdge = (presentsYay.presentsPos.Y + 600);
            presentsBottomEdge = (presentsYay.presentsPos.Y + 600) + presentsYay.presentsSize.Y;

            presentOverlapLeft = presentsEdge < playerRightEdge;
            presentOverlapRight = presentsRightEdge > playerEdge;
            presentOverlapTop = presentsTopEdge < playerBottom;
            presentOverlapBottom = presentsBottomEdge > playerTop;

            doesPresentOverlap = presentOverlapLeft && presentOverlapRight && presentOverlapTop && presentOverlapBottom;
            if (doesPresentOverlap)
            {
                Draw.LineColor = Color.Green;
                Draw.FillColor = Color.Green;
                Draw.Rectangle(presentsYay.presentsPos.X + 800, presentsYay.presentsPos.Y + 670, presentsYay.presentsSize.X, presentsYay.presentsSize.Y);
                present5Collected = true;
            }

            //present #6            
            presentsEdge = presentsYay.presentsPos.X + 670;
            presentsRightEdge = (presentsYay.presentsPos.X + 670) + (presentsYay.presentsSize.X);
            presentsTopEdge = (presentsYay.presentsPos.Y + 600);
            presentsBottomEdge = (presentsYay.presentsPos.Y + 600) + presentsYay.presentsSize.Y;

            presentOverlapLeft = presentsEdge < playerRightEdge;
            presentOverlapRight = presentsRightEdge > playerEdge;
            presentOverlapTop = presentsTopEdge < playerBottom;
            presentOverlapBottom = presentsBottomEdge > playerTop;

            doesPresentOverlap = presentOverlapLeft && presentOverlapRight && presentOverlapTop && presentOverlapBottom;
            if (doesPresentOverlap)
            {
                Draw.LineColor = Color.Green;
                Draw.FillColor = Color.Green;
                Draw.Rectangle(presentsYay.presentsPos.X + 670, presentsYay.presentsPos.Y + 670, presentsYay.presentsSize.X, presentsYay.presentsSize.Y);
                present6Collected = true;
            }

            //present #7            
            presentsEdge = presentsYay.presentsPos.X + 670;
            presentsRightEdge = (presentsYay.presentsPos.X + 670) + (presentsYay.presentsSize.X);
            presentsTopEdge = (presentsYay.presentsPos.Y - 70);
            presentsBottomEdge = (presentsYay.presentsPos.Y - 70) + presentsYay.presentsSize.Y;

            presentOverlapLeft = presentsEdge < playerRightEdge;
            presentOverlapRight = presentsRightEdge > playerEdge;
            presentOverlapTop = presentsTopEdge < playerBottom;
            presentOverlapBottom = presentsBottomEdge > playerTop;

            doesPresentOverlap = presentOverlapLeft && presentOverlapRight && presentOverlapTop && presentOverlapBottom;
            if (doesPresentOverlap)
            {
                Draw.LineColor = Color.Green;
                Draw.FillColor = Color.Green;
                Draw.Rectangle(presentsYay.presentsPos.X + 670, presentsYay.presentsPos.Y, presentsYay.presentsSize.X, presentsYay.presentsSize.Y);
                present7Collected = true;
            }

            //present #8           
            presentsEdge = presentsYay.presentsPos.X + 1030;
            presentsRightEdge = (presentsYay.presentsPos.X + 1030) + (presentsYay.presentsSize.X);
            presentsTopEdge = (presentsYay.presentsPos.Y - 70);
            presentsBottomEdge = (presentsYay.presentsPos.Y - 70) + presentsYay.presentsSize.Y;

            presentOverlapLeft = presentsEdge < playerRightEdge;
            presentOverlapRight = presentsRightEdge > playerEdge;
            presentOverlapTop = presentsTopEdge < playerBottom;
            presentOverlapBottom = presentsBottomEdge > playerTop;

            doesPresentOverlap = presentOverlapLeft && presentOverlapRight && presentOverlapTop && presentOverlapBottom;
            if (doesPresentOverlap)
            {
                Draw.LineColor = Color.Green;
                Draw.FillColor = Color.Green;
                Draw.Rectangle(presentsYay.presentsPos.X + 1030, presentsYay.presentsPos.Y, presentsYay.presentsSize.X, presentsYay.presentsSize.Y);
                present8Collected = true;
            }

            //present #9
            presentsEdge = presentsYay.presentsPos.X + 160;
            presentsRightEdge = (presentsYay.presentsPos.X + 160) + (presentsYay.presentsSize.X);
            presentsTopEdge = (presentsYay.presentsPos.Y + 450);
            presentsBottomEdge = (presentsYay.presentsPos.Y + 450) + presentsYay.presentsSize.Y;

            presentOverlapLeft = presentsEdge < playerRightEdge;
            presentOverlapRight = presentsRightEdge > playerEdge;
            presentOverlapTop = presentsTopEdge < playerBottom;
            presentOverlapBottom = presentsBottomEdge > playerTop;

            doesPresentOverlap = presentOverlapLeft && presentOverlapRight && presentOverlapTop && presentOverlapBottom;
            if (doesPresentOverlap)
            {
                Draw.LineColor = Color.Green;
                Draw.FillColor = Color.Green;
                Draw.Rectangle(presentsYay.presentsPos.X + 160, presentsYay.presentsPos.Y + 550, presentsYay.presentsSize.X, presentsYay.presentsSize.Y);
                present9Collected = true;
            }

            //present #10
            presentsEdge = presentsYay.presentsPos.X + 950;
            presentsRightEdge = (presentsYay.presentsPos.X + 950) + (presentsYay.presentsSize.X);
            presentsTopEdge = (presentsYay.presentsPos.Y + 430);
            presentsBottomEdge = (presentsYay.presentsPos.Y + 430) + presentsYay.presentsSize.Y;

            presentOverlapLeft = presentsEdge < playerRightEdge;
            presentOverlapRight = presentsRightEdge > playerEdge;
            presentOverlapTop = presentsTopEdge < playerBottom;
            presentOverlapBottom = presentsBottomEdge > playerTop;

            doesPresentOverlap = presentOverlapLeft && presentOverlapRight && presentOverlapTop && presentOverlapBottom;
            if (doesPresentOverlap)
            {
                Draw.LineColor = Color.Green;
                Draw.FillColor = Color.Green;
                Draw.Rectangle(presentsYay.presentsPos.X + 950, presentsYay.presentsPos.Y + 500, presentsYay.presentsSize.X, presentsYay.presentsSize.Y);
                present10Collected = true;
            }

            bool isAllGiftsCollected = present1Collected && present2Collected && present3Collected && present4Collected && present5Collected && present6Collected && present7Collected && present8Collected && present9Collected && present10Collected;
            if (isAllGiftsCollected)
            {
                //draw the imposing exit
                Draw.FillColor = Color.Black;
                Draw.Rectangle(exitPos, exitSize);

                theExit = 1;
               
            }
        }



                public bool GetDetection()
                 {
                    return onPit;
                }

        public int ReturnTheExit(){
            return theExit;
        }

        public void Reset(){
             present1Collected = false;
             present2Collected = false;
             present3Collected = false;
             present4Collected = false;
             present5Collected = false;
             present6Collected = false;
             present7Collected = false;
             present8Collected = false;
             present9Collected = false;
             present10Collected = false;
            onPit = false;
            theExit = 0;
        }
    }
}
