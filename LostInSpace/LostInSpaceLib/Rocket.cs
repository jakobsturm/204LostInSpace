using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace LostInSpaceLib
{
    public class Rocket : Entity
    {
        private float velocity;
        private Vector2 movementVector;
        private Vector2 position;

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

        //-----------------------------------------------------------------------------------------

        public Rocket()
        {
            Position = new Vector2(0, 0);
        }

        //-----------------------------------------------------------------------------------------

        public override void Draw(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            MovementVector.Normalize();
            float movementFactor = velocity * (float)gameTime.ElapsedGameTime.TotalSeconds;

            Position = new Vector2(movementVector.X * movementFactor, movementVector.Y * movementFactor);


        }
    }
}
