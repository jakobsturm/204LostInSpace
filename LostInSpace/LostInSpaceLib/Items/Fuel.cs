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

        private Texture2D FuelTexture;
        public Vector2 FuelPosition { get; set; }
        SpriteBatch spriteBatch;

        public Fuel(float posX, float posY, Texture2D texture)
        {
            FuelPosition = new Vector2(posX, posY);
            //spriteBatch = new SpriteBatch();
            FuelTexture = texture;
        }



        public void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

            //spriteBatch.Draw(FuelTexture, Position, Color.White);

            spriteBatch.End();
        }
    }
}
