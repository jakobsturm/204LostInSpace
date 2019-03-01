using LostInSpaceLib.Items;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LostInSpaceLib
{
    public class LostInSpaceGame
    {
        const float MONEY_FACTOR = 0.05f;

        GraphicsDevice graphicsDevice;
        SpriteBatch spriteBatch;

        Song background_music;
        Dictionary<string, Texture2D> textures;
        Size windowSize;

        private float money;
        private Rocket rocket;
        private Vector2 backgroundOffset;

        private ItemManager itemManager;

        public float Money
        {
            get { return money; }
            set { money = value; }
        }

        public Rocket Rocket
        {
            get { return rocket; }
            set { rocket = value; }
        }

        //-----------------------------------------------------------------------------------------

        public LostInSpaceGame(GraphicsDevice graphicsDevice, Song background_music, Dictionary<string, Texture2D> textures, Size windowSize)
        {
            this.graphicsDevice = graphicsDevice;
            this.background_music = background_music;
            this.textures = textures;
            this.windowSize = windowSize;

            Initialize();
            LoadContent();
        }
        
        //-----------------------------------------------------------------------------------------

        public void Initialize()
        {
            money = 0;

            rocket = new Rocket(graphicsDevice, textures["Rocket"], windowSize);

            //itemManager = new ItemManager();
        }
        
        public void LoadContent()
        {
            spriteBatch = new SpriteBatch(graphicsDevice);

            MediaPlayer.Play(background_music);
        }

        public void Update(GameTime gameTime)
        {
            float newMoneyValue = rocket.Position.Y * MONEY_FACTOR;

            if (money < newMoneyValue)
            {
                money = newMoneyValue;
            }

            if (rocket.Position.Y > 200)
            {
                backgroundOffset.Y = rocket.Position.Y - 200;
            }

            rocket.Update(gameTime);
        }

        public void Draw(GameTime gameTime)
        {
            graphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();

            spriteBatch.Draw(textures["Hintergrund"], new Rectangle((int)backgroundOffset.X, (int)(backgroundOffset.Y - (textures["Hintergrund"].Height - windowSize.Height)), (int)windowSize.Width, (int)textures["Hintergrund"].Height), Color.White);

            spriteBatch.End();

            rocket.Draw(gameTime);
        }
    }
}
