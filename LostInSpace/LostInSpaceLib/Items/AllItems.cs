using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        SpriteBatch spriteBatch;

        public AllItems(float posX, float posY, Dictionary<string, Texture2D> textures, int WhatItem)
        {

            Position = new Vector2(posX, posY);


            //spriteBatch = new SpriteBatch();
            switch (WhatItem)
            {
                case 1:
                    Texture = textures["Health"];
                    break;
                case 2:
                    Texture = textures["Money"];
                    break;
                case 3:
                    Texture = textures["Fuel"];
                    break;
            }
        }



        public void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(Texture, Position, Color.White);

            allitems.Add(new L_AllItems() { PositionItem = Position, s = new System.Windows.Size(50,50)});

            spriteBatch.End();
        }
    }
}
