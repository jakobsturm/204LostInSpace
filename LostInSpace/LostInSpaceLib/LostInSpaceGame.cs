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
        GraphicsDeviceManager graphics;
        GraphicsDevice graphicsDevice;
        SpriteBatch spriteBatch;

        public LostInSpaceGame()
        {

        }
        
        public void Initialize()
        {

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

        }

        public void Draw(GameTime gameTime)
        {
            graphicsDevice.Clear(Color.CornflowerBlue);


        }
    }
}
