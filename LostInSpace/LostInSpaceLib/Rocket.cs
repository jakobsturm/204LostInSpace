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

        private int hullPoints;
        private float fuel;
        private float money;

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


        public float Money
        {
            get { return money; }
            set { money = value; }
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
