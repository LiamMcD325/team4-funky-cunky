// Include the namespaces (code libraries) you need below.
//using GAME_10003_Game_Development_Foundations___2D_Game_Template__v1._4_1.MohawkGame2D;
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

        
        // Place your variables here:
        Player player = new Player();

        Cube cubes = new Cube();
        //Enemy enemies = new Enemy();

        Level1 level1 = new Level1();
        Level2 level2 = new Level2();
        FinalLevel level3 = new FinalLevel();

        //Game over screen when the player dies
        GameOver gameOverScreen = new GameOver();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(1100, 800);
            Window.SetTitle("Home Alone 7");
            player.Setup();
            cubes.Setup();
            gameOverScreen.Setup();
            level1.Setup();
            level2.Setup();
            level3.Setup();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            cubes.Update(player.HasPresent());
            //enemies.update();

            {
                Window.ClearBackground(Color.White);

                cubes.Update(player.HasPresent());

                if (player.GetLives() == 1)
                {
                    
                    level1.Update(player.FeetCollision());
                    player.PassLevel1(level1.ReturnTheExit());
                }
                if (player.GetLives() == 2)
                {
                    player.GetDirection();
                    level2.Update(player.FeetCollision());
                    
                   
                }
                if (player.GetLives() == 3)
                {
                    level3.Update(player.FeetCollision());
                    player.Kill(level3.GetIsDead());
                }

                
                player.Update(cubes.getDetection(), level1.GetDetection(), level2.GetDetection());

                if (player.GetLives() <= -1) { 
                    gameOverScreen.Update();

                    if (Input.IsKeyboardKeyDown(KeyboardInput.Enter) == true)
                    {
                        player.Reset();
                        level1.Reset();
                        level2.Reset();
                        level3.Reset();


                    }
                }

                // speed = new Vector2(whatever the fuck, the same thing);
                // angle = Vector2.Normalize(enemy.pos - player.pos);
                // enemy.pos -= angle * speed
            }


        }
    }

}
