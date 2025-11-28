using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Player
    {
        public Vector2 position = new Vector2(100, 100);
        Vector2 size;
        public Vector2 feetPosition; //Used to check collision closer to legs and feet
        public Vector2 feetSize = new Vector2(100, 40); //Used to check collision closer to legs and feet
        Texture2D texture;
        int score;
        int lives = 0; //How many lives the player has
        string direction = "";
        bool hasPresent = false;

        public Player() { }

        /// <summary>
        ///  Setup runs once before the game loop begins.
        /// </summary>
        public void Setup() {
            feetPosition = new Vector2(position.X, position.Y + 60); 
            texture = Graphics.LoadTexture("MohawkGame2D\\Images\\Kevin.png");
            size = new Vector2(100, 200);
        }

        /// <summary>
        /// Update runs every frame.
        /// </summary>
        public void Update(Vector2 presentCollision, bool holeCollision, bool holeCollision2) {
            if (holeCollision == true) {CheckHole();}
            if (holeCollision2 == true) {CheckHole();}
            Inputs();

            CheckPresent(presentCollision);
            Graphics.Draw(texture, position);

            

        }

        /// <summary>
        /// Checks for player inputs via controller or keyboard
        /// </summary>
        void Inputs(){
    
            if ((Input.IsKeyboardKeyDown(KeyboardInput.Right) == true))
            {
                position.X += 10;
                direction = "right";
            }
            else if ((Input.IsKeyboardKeyDown(KeyboardInput.Left) == true))
            {
                position.X -= 10;
                direction = "left";
            }
            if ((Input.IsKeyboardKeyDown(KeyboardInput.Down) == true))
            {
                position.Y += 10;
                direction = "down";
            }
            else if ((Input.IsKeyboardKeyDown(KeyboardInput.Up) == true))
            {
                position.Y -= 10;
                direction = "up";
            }

            //Used to test game over
            if (Input.IsKeyboardKeyDown(KeyboardInput.P) == true )
            {
                lives = 0;
            }
 

            //Used to test level 1
            if ((score >= 50) && (lives == 0))
            {
                lives = 1;
            }


            //Used to test level 2
            if ((score >= 100)&&(lives == 1))
            {
                lives = 2;
            }


            if ((score >= 140) && (lives == 2))
            {
                lives = 3;
            }

            feetPosition.X = position.X;
            feetPosition.Y = position.Y + 60;

            //OutOfBounds();
        }

        /// <summary>
        /// Checks if the player is touching a present
        /// </summary>
        /// <param name="presentCollision">The point of the present</param>
        void CheckPresent(Vector2 presentCollision){
            if ((position.X + size.X > presentCollision.X - 45)&&(position.X < presentCollision.X + 60)){
                if ((position.Y + size.Y > presentCollision.Y - 45) && (position.Y < presentCollision.Y + 65))
                {
                    
                    hasPresent = true;
                    score += 10;
                    Console.WriteLine(score);
                }
            }
            else {
                hasPresent = false;
            }
        }

        /// <summary>
        /// If the player is touching a present
        /// </summary>
        /// <returns></returns>
        public bool HasPresent() { 
            return hasPresent; 
        }

        /// <summary>
        /// The lives count of the player, keeps it private
        /// </summary>
        /// <returns>Lives count</returns>
        public int GetLives() { 
            return lives; 
        }

        /// <summary>
        /// Used to move around the player on ice
        /// </summary>
        public void GetDirection(){
            if (direction == "right"){ position.X += 5; }
            else if (direction == "left"){ position.X -= 5; }
            else if (direction == "down") { position.Y += 5; }
            else if (direction == "up") { position.Y -= 5; }
        }

        public void IsOnIce(){ }

        /// <summary>
        /// Checks if the player has gone out of bounds
        /// </summary>
        public void OutOfBounds()
        {
            if (position.X < 0){ position.X = 0; }
            if (position.X > 1000){ position.X = 1000; }
            if (position.Y < 0){ position.Y = 0; }
            if (position.Y > 600){ position.Y = 600; }
        }

        /// <summary>
        /// Returns the position of the player's feet
        /// </summary>
        /// <returns></returns>
        public Vector2 FeetCollision(){
            return feetPosition;        
        }

        public void CheckHole(){
            position = new Vector2 (10, 10);
            feetPosition.X = position.X;
            feetPosition.Y = position.Y + 60;
            lives -= 100;
            
        }

        public void Kill(bool isdead)
        {
            if(isdead == true) { lives = -1; }

        }

        /// <summary>
        /// Used to pass level 2
        /// </summary>
        /// <param name="deez">Checks if all presents have been collected</param>
        public void PassLevel1(int deez)
        {
            if (deez == 1)
            {
                lives = 2;
            }

        }

        /// <summary>
        /// Used to reset f
        /// </summary>
        public void Reset()
        {

            Console.WriteLine(lives);
            Console.WriteLine("Pressed!");
                lives = 0;
                position = new Vector2(100, 100);
                score = 0;
                
                


        }
    }
}
