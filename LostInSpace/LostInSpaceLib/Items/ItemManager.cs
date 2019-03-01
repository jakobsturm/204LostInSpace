using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Windows;

namespace LostInSpaceLib.Items
{
    public class ItemManager
    {

        Health h;
        Fuel f;
        Money m;

        public int GeneratedRandom { get; set; }
        public int RndPosX { get; set; }
        public int RndPosY { get; set; }

        Random rnd = new Random();


        public ItemManager(Rocket rocket, Size s, Dictionary<string, Texture2D> textures)
        {

            ItemPicker(rocket.Position.Y, s, textures);


        }

        public void ItemPicker(float RocketPosY, Size s, Dictionary<string, Texture2D> textures)
        {
            GeneratedRandom = rnd.Next(1, 4);
            RndPosX = rnd.Next(500, 1500);
            RndPosY = rnd.Next(100, 1080);

            switch (GeneratedRandom)
            {
                case 1:
                    h = new Health(RndPosX, RndPosY, textures["Health"]);
                    break;
                case 2:
                    f = new Fuel(RndPosX, RndPosY, textures["Fuel"]);
                    break;
                case 3:
                    m = new Money(RndPosX, RndPosY, textures["Money"]);
                    break;
            }

            
            
        }
    }
}
