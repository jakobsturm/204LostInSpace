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
        private float velocity;
        private Vector2 movementVector;
        private Vector2 position;
        private Texture2D texture;
        private SpriteBatch spriteBatch;
        private Size windowSize;
        private Vector2 offset;

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

        public Rocket(GraphicsDevice graphicsDevice, Texture2D texture, Size windowSize)
        {
            Position = new Vector2(0, 0);

            this.texture = texture;
            this.windowSize = windowSize;

            spriteBatch = new SpriteBatch(graphicsDevice);
            offset = new Vector2((float)windowSize.Width / 2 - texture.Width / 2, (float)windowSize.Height - texture.Height);
        }

        //-----------------------------------------------------------------------------------------

        public override void Update(GameTime gameTime)
        {
            MovementVector.Normalize();
            float movementFactor = velocity * (float)gameTime.ElapsedGameTime.TotalSeconds;

            Position = new Vector2(movementVector.X * movementFactor, movementVector.Y * movementFactor);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(texture, Position + offset, Color.White);

            spriteBatch.End();
        }
    }
}
