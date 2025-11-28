using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{

    public class Enemy
    {
        Player player = new Player();
        Vector2 enemyPos = new (0, 0);
             
        public void update()
        {
            
            Vector2 enemySpeed = new(100, 0);

            Vector2 enemyToPlayer = player.position - enemyPos;

            enemySpeed = Vector2.Normalize(enemyToPlayer) * 200.0f;

            enemyPos += enemySpeed * Time.DeltaTime;
           
            Draw.FillColor = Color.OffWhite;

            Draw.Circle(enemyPos, 50);

        }
    }
}