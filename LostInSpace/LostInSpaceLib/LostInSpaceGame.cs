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
        SpriteFont spriteFont;

        Song background_music;
        Dictionary<string, Texture2D> textures;
        Size windowSize;

        private float money;
        private Rocket rocket;
        private Vector2 backgroundOffset;
        private Vector2 planetOffset;

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

        public LostInSpaceGame(GraphicsDevice graphicsDevice, Song background_music, Dictionary<string, Texture2D> textures, Size windowSize, SpriteFont spriteFont)
        {
            this.graphicsDevice = graphicsDevice;
            this.background_music = background_music;
            this.textures = textures;
            this.windowSize = windowSize;
            this.spriteFont = spriteFont;

            Initialize();
            LoadContent();
        }
        
        //-----------------------------------------------------------------------------------------

        public void Initialize()
        {
            money = 0;

            rocket = new Rocket(graphicsDevice, textures["Rocket"], windowSize, 100f);

            //itemManager = new ItemManager();
        }
        
        public void LoadContent()
        {
            spriteBatch = new SpriteBatch(graphicsDevice);

            MediaPlayer.Play(background_music);
        }

        public void Update(GameTime gameTime)
        {
            if (rocket.isFlying)
            {
                float newMoneyValue = rocket.Position.Y * MONEY_FACTOR;

                if (money < newMoneyValue)
                {
                    money = newMoneyValue;
                }

                if (rocket.Position.Y > 200)
                {
                    backgroundOffset.Y = rocket.Position.Y - 200;
                    planetOffset.Y -= 5 * rocket.velocity * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }

                rocket.Update(gameTime);
            }
        }

        public void Draw(GameTime gameTime)
        {
            graphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();

            spriteBatch.Draw(textures["Hintergrund"], new Rectangle((int)backgroundOffset.X, (int)(backgroundOffset.Y - (textures["Hintergrund"].Height - windowSize.Height)), (int)windowSize.Width, (int)textures["Hintergrund"].Height), Color.White);
            spriteBatch.Draw(textures["Planet"], new Rectangle(0, (int)(windowSize.Height - textures["Planet"].Height - planetOffset.Y), textures["Planet"].Width, textures["Planet"].Height), Color.White);

            spriteBatch.DrawString(spriteFont, $"Money: {(int)money}", new Vector2(10, 10), Color.White);
            spriteBatch.DrawString(spriteFont, $"Fuel: {(int)rocket.Fuel}", new Vector2(10, 25), Color.White);

            spriteBatch.End();

            rocket.Draw(gameTime);
        }

        public bool CollisionDetection(Vector2 position1, Vector2 size1, Vector2 position2, Vector2 size2)
        {
            for (int i = (int)position1.X; i < position1.X + size1.X; i++)
            {
                for (int j = (int)position1.Y; j < position1.Y + size1.Y; j++)
                {
                    if (position2.X <= i && i <= position2.X + size2.X)
                    {
                        if (position2.Y <= j && j <= position2.Y + size2.Y)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
