using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LostInSpaceLib
{
    public class Rocket : Entity
    {
        const int TEXTURE_WIDTH = 145;
        const int TEXTURE_HEIGHT = 200;

        const float FUEL_FACTOR = 0.1f;

        public float velocity;
        private Vector2 movementVector;
        private Vector2 position;
        private Texture2D texture;
        private SpriteBatch spriteBatch;
        private Size windowSize;
        private Vector2 offset;
        public bool isFlying;

        private int hullPoints;
        private float fuel;

        public Vector2 MovementVector
        {
            get { return movementVector; }
            set { movementVector = value; }
        }
        
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }
        
        public int HullPoints
        {
            get { return hullPoints; }
            set { hullPoints = value; }
        }
        
        public float Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        //-----------------------------------------------------------------------------------------

        public Rocket(GraphicsDevice graphicsDevice, Texture2D texture, Size windowSize, float fuel)
        {
            Position = new Vector2(0, 0);
            velocity = 20;
            isFlying = true;

            this.texture = texture;
            this.windowSize = windowSize;
            this.fuel = fuel;

            spriteBatch = new SpriteBatch(graphicsDevice);
            offset = new Vector2((float)windowSize.Width / 2 - TEXTURE_WIDTH / 2, (float)windowSize.Height - TEXTURE_HEIGHT);
        }

        //-----------------------------------------------------------------------------------------

        public override void Update(GameTime gameTime)
        {
            if (isFlying == true)
            {
                float movementFactor = velocity * (float)gameTime.ElapsedGameTime.TotalSeconds;

                Position += new Vector2(movementVector.X * movementFactor, movementVector.Y * movementFactor);
                Console.WriteLine(Position.ToString());

                if (Position.Y > 200)
                {
                    offset.Y += movementVector.Y * movementFactor;
                }
            }

            if (fuel > 0)
            {
                fuel -= FUEL_FACTOR;
            }
            else
            {
                fuel = 0;
                isFlying = false;
            }
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(texture, new Rectangle((-Position + offset).ToPoint(), new Microsoft.Xna.Framework.Point(TEXTURE_WIDTH, TEXTURE_HEIGHT)), Color.White);

            spriteBatch.End();
        }
    }
}
