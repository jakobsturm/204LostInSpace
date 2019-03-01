using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace LostInSpaceLib
{
    public class Fuel
    {
        public Fuel(float posX, float posY)
        {
            FuelPosition = new Vector2(posX, posY);
        }

        public Vector2 FuelPosition { get; set; }
    }
}
