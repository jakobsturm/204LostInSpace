using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LostInSpaceLib
{
    public class Fuel
    {

        const int ITEM_LW = 50;


        private Texture2D FuelTexture;
        public Vector2 FuelPosition { get; set; }

        public int PosX { get; set; }
        public int PosY { get; set; }

        SpriteBatch spriteBatch;

        public Fuel(float posX, float posY, Texture2D texture)
        {
            FuelPosition = new Vector2(posX, posY);
            spriteBatch = new SpriteBatch(graphicsDevice);
            FuelTexture = texture;

            PosX = Convert.ToInt32(posX);
            PosY = Convert.ToInt32(posY);
        }



        public void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(FuelTexture, new Rectangle(PosX, PosY,ITEM_LW, ITEM_LW), Color.White);

            spriteBatch.End();
        }
    }
}
