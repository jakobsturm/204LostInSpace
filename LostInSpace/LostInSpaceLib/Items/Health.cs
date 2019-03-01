using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace LostInSpaceLib
{
    public class Health
    {
        public Health(float posX, float posY)
        {
            HealthPosition = new Vector2(posX, posY);
        }

        public Vector2 HealthPosition { get; set; }
    }
}
