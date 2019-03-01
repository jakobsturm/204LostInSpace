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

        const int THRESHHOLD_1 = 5;
        const int THRESHHOLD_2 = 25;
        const int THRESHHOLD_3 = 50;
        const int THRESHHOLD_4 = 70;
        const int THRESHHOLD_5 = 100;
        const int THRESHHOLD_6 = 200;

        private int Used { get; set; }

        AllItems AI;
        SpriteBatch spriteBatch;

        public int GeneratedRandom { get; set; }
        public int RndPosX { get; set; }
        public int RndPosY { get; set; }

        Random rnd = new Random();


        public ItemManager(/*Rocket rocket, Size s, Dictionary<string, Texture2D> textures, GraphicsDevice graphicsDevice*/)
        {

        }

        public void ItemPicker(Dictionary<string, Texture2D> textures, GraphicsDevice graphicsDevice)
        {
            GeneratedRandom = rnd.Next(1, 4);
            RndPosX = rnd.Next(500, 1500);
            RndPosY = rnd.Next(100, 1080);

            AI = new AllItems(RndPosX, RndPosY, textures, GeneratedRandom, graphicsDevice);
        }

        public void Update(GameTime gameTime, Rocket rocket, Dictionary<string, Texture2D> textures, GraphicsDevice graphicsDevice)
        {
            if (gameTime.TotalGameTime.Seconds >= THRESHHOLD_1 && gameTime.TotalGameTime.Seconds <= THRESHHOLD_2)
            {
                if (rnd.Next(1, 5) == 3)
                {
                    ItemPicker(textures, graphicsDevice);
                }
            }
            else if (gameTime.TotalGameTime.Seconds >= THRESHHOLD_2 && gameTime.TotalGameTime.Seconds <= THRESHHOLD_3)
            {
                if (rnd.Next(1, 9) == 3)
                {
                    ItemPicker(textures, graphicsDevice);
                }
            }
            else if (gameTime.TotalGameTime.Seconds >= THRESHHOLD_3 && gameTime.TotalGameTime.Seconds <= THRESHHOLD_4)
            {
                if (rnd.Next(1, 14) == 3)
                {
                    ItemPicker(textures, graphicsDevice);
                }
            }
            else if (gameTime.TotalGameTime.Seconds >= THRESHHOLD_4 && gameTime.TotalGameTime.Seconds <= THRESHHOLD_5)
            {
                if (rnd.Next(1, 18) == 3)
                {
                    ItemPicker(textures, graphicsDevice);
                }
            }
            else if (gameTime.TotalGameTime.Seconds >= THRESHHOLD_5 && gameTime.TotalGameTime.Seconds <= THRESHHOLD_6)
            {
                if (rnd.Next(1, 22) == 3)
                {
                    ItemPicker(textures, graphicsDevice);
                }
            }
            else if (gameTime.TotalGameTime.Seconds >= THRESHHOLD_6)
            {
                if (rnd.Next(1, 25) == 3)
                {
                    ItemPicker(textures, graphicsDevice);
                }
            }
        }
    }
}
