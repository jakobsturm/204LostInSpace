using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using LostInSpaceLib.Items;

namespace LostInSpaceLib
{
    public class AllItems
    {
        public List<L_AllItems> allitems;

        private Texture2D Texture;
        public Vector2 Position { get; set; }


        public AllItems(float posX, float posY, Dictionary<string, Texture2D> textures, int WhatItem, GraphicsDevice graphicsDevice)
        {

            Position = new Vector2(posX, posY);
            allitems = new List<L_AllItems>();

            switch (WhatItem)
            {
                case 1:
                    Texture = textures["Health"];
                    Draw(graphicsDevice, allitems);
                    break;
                case 2:
                    Texture = textures["Money"];
                    Draw(graphicsDevice, allitems);
                    break;
                case 3:
                    Texture = textures["Fuel"];
                    Draw(graphicsDevice, allitems);
                    break;
            }
        }



        public void Draw(GraphicsDevice graphicsDevice, List<L_AllItems> allitems)
        {
            SpriteBatch spriteBatch = new SpriteBatch(graphicsDevice);
            spriteBatch.Begin();

            spriteBatch.Draw(Texture, Position, Color.White);

            L_AllItems data = new L_AllItems();
            data.PositionItem = Position;
            data.s = new System.Windows.Size(50, 50);

            allitems.Add(data);

            spriteBatch.End();
        }
    }
}
