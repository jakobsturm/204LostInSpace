using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LostInSpaceLib
{
    public class Health
    {

        public Health(float posX, float posY, Texture2D texture)
        {
            HealthPosition = new Vector2(posX, posY);
            HealthTexture = texture;
        }

        private Texture2D HealthTexture;
        public Vector2 HealthPosition { get; set; }
        

    }
}
