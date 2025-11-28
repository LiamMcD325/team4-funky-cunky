using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MohawkGame2D
{


    public class Assets
    {
        

        public Assets() { }
        public void Setup()
        {
            /*string[] textureFilePath = new string[3];
            Texture2D playerTexture;
            textureFilePath[0] = "MohawkGame2D\\Images\\StopSign.png";
            playerTexture = Graphics.LoadTexture(textureFilePath[0]);*/
        }

        /// <summary>
        /// Used to change position
        /// </summary>
        /// <param name="position">Position</param>
        public void Update(Vector2 position, string texturePath)
        {
             Vector2 textureSize = new Vector2(Window.Width, Window.Height);
            Texture2D background1 = Graphics.LoadTexture(texturePath);
            Graphics.DrawSubset(background1, position, position, textureSize);

        }

        /// <summary>
        /// Used for default position
        /// </summary>
        public void Update(string texturePath)
        {
            
            Vector2 position = new Vector2(0,0);
            Vector2 textureSize = new Vector2(Window.Width, Window.Height);
            Texture2D background1 = Graphics.LoadTexture(texturePath);
            Graphics.DrawSubset(background1, position, position, textureSize);
        }



    }
}
