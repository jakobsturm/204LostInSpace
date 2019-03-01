﻿using LostInSpaceLib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;
using System.Windows;

namespace LostInSpace
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont spriteFont;

        LostInSpaceGame lostInSpaceGame;

        Song background_music;
        Dictionary<string, Texture2D> textures;

        float fuel;

        public Game1(float fuel)
        {
            this.IsMouseVisible = true;
            this.fuel = fuel;

            graphics = new GraphicsDeviceManager(this);

            graphics.PreferredBackBufferWidth = 1080;
            graphics.PreferredBackBufferHeight = 1080;
            //graphics.IsFullScreen = true;
            graphics.ApplyChanges();

            Content.RootDirectory = "Content";
        }
        
        protected override void Initialize()
        {
            textures = new Dictionary<string, Texture2D>();

            // Add all the textures here!!!
            textures.Add("Rocket", Content.Load<Texture2D>("rocket"));
            textures.Add("Planet", Content.Load<Texture2D>("planet"));
            textures.Add("Hintergrund", Content.Load<Texture2D>("background_v2"));
            textures.Add("Fuel", GetTexture2DFromColour(GraphicsDevice, Color.Gray, 10, 10));
            textures.Add("Health", GetTexture2DFromColour(GraphicsDevice, Color.Red, 10, 10));
            textures.Add("Money", GetTexture2DFromColour(GraphicsDevice, Color.Green, 10, 10));

            spriteFont = Content.Load<SpriteFont>("spritefont");

            background_music = Content.Load<Song>("Tragik_in_A-Moll");

            lostInSpaceGame = new LostInSpaceGame(GraphicsDevice, background_music, textures, new Size(graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight), spriteFont, fuel);

            base.Initialize();
        }
        
        protected override void LoadContent()
        {
        }
        
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }
        
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            KeyboardState keyboardState = Keyboard.GetState();
            Vector2 movementVector = new Vector2(0, 5);

            if (keyboardState.IsKeyDown(Keys.Left))
            {
                if (lostInSpaceGame.Rocket.Position.X < 470)
                {
                    movementVector += new Vector2(5, 0);
                }
            }

            if (keyboardState.IsKeyDown(Keys.Right))
            {
                if (lostInSpaceGame.Rocket.Position.X > -470)
                {
                    movementVector += new Vector2(-5, 0);
                }
            }

            lostInSpaceGame.Rocket.MovementVector = movementVector;
            lostInSpaceGame.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            lostInSpaceGame.Draw(gameTime);

            base.Draw(gameTime);
        }

        //-----------------------------------------------------------------------------------------

        public Texture2D GetTexture2DFromColour(GraphicsDevice graphics, Color colour, int width, int height)
        {
            Texture2D texture = new Texture2D(graphics, width, height);
            Color[] data = new Color[width * height];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = colour;
            }

            texture.SetData(data);

            return texture;
        }
    }
}
