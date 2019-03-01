using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostInSpaceLib
{
    public class LostInSpaceGame
    {
        const float moneyFactor = 0.05f;

        GraphicsDevice graphicsDevice;
        SpriteBatch spriteBatch;

        Rocket rocket;
        float money;

        public LostInSpaceGame(GraphicsDevice graphicsDevice)
        {
            this.graphicsDevice = graphicsDevice;
        }
        
        public void Initialize()
        {
            rocket = new Rocket();
        }
        
        public void LoadContent()
        {
            spriteBatch = new SpriteBatch(graphicsDevice);
        }
        
        public void UnloadContent()
        {

        }
        
        public void Update(GameTime gameTime)
        {
            float newMoneyValue = rocket.Position.Y * moneyFactor;

            if (money < newMoneyValue)
            {
                money = newMoneyValue;
            }

            rocket.Update(gameTime);
        }

        public void Draw(GameTime gameTime)
        {
            graphicsDevice.Clear(Color.CornflowerBlue);

            rocket.Draw(gameTime);
        }
    }
}
