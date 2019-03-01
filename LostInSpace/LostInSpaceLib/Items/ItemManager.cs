using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace LostInSpaceLib.Items
{
    public class ItemManager
    {


        public int GeneratedRandom { get; set; }
        Random rnd = new Random();


        public ItemManager(GameTime gameTime, Rocket rocket)
        {

            ItemPicker(rocket.Position.Y);
        }

        public void ItemPicker(float RocketPosY)
        {
            GeneratedRandom = rnd.Next(1, 3);

            switch (RocketPosY)
            {
                case 5000:

                    break;

                case 50000:

                    break;

                case 500000:

                    break;

                case 5000000:

                    break;
            }
        }
    }
}
