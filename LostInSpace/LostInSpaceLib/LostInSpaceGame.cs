using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
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

        Song background_music;
        Dictionary<string, Texture2D> textures;

        Rocket rocket;
        float money;

        public LostInSpaceGame(GraphicsDevice graphicsDevice, Song background_music, Dictionary<string, Texture2D> textures)
        {
            this.graphicsDevice = graphicsDevice;
            this.background_music = background_music;
            this.textures = textures;

            Initialize();
            LoadContent();
        }
        
        public void Initialize()
        {
            money = 0;

            rocket = new Rocket(graphicsDevice, textures["Rocket"]);
        }
        
        public void LoadContent()
        {
            spriteBatch = new SpriteBatch(graphicsDevice);

            MediaPlayer.Play(background_music);
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
